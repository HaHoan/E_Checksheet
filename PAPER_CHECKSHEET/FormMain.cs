using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAPER_CHECKSHEET
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dtgvSpec.Columns.Add("Column", "Spec");
            dtgvSpec.Rows.Add(Constants.A1);
            dtgvSpec.Rows.Add(Constants.A2);
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {
            var countColumn = dtgvSpec.ColumnCount;
            if (countColumn < 6)
            {
                dtgvSpec.Columns.Add("Column", "Lần " + countColumn);
            }
            else if (countColumn < 16)
            {
                int index = countColumn - 5;
                dtgvSpec.Columns.Add("Column", (index * 200).ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addToCombobox();
        }

        private void OnlyNumberPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        void addToCombobox()
        {

            using (var db = new E_CHECKSHEETEntities())
            {
                var listCus = db.CUSTOMERs.ToList();
                cbbCustomer.DataSource = listCus;
                cbbCustomer.DisplayMember = "CustomerName";
                var listModel = db.MODELs.ToList();
                cbbModel.DataSource = listModel;
                cbbModel.DisplayMember = "ModelName";
                var listLK = db.MALINHKIENs.ToList();
                cbbMaLK.DataSource = listLK;
                cbbMaLK.DisplayMember = "MaLinhKien1";
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            var setting = new FormSetting();
            setting.ActionClosed += () =>
            {
                addToCombobox();
            };
            setting.ShowDialog();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (var db = new E_CHECKSHEETEntities())
            {
                using (DbContextTransaction transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var checksheet = db.CHECKSHEETs.Where(m => m.WO == txbWO.Text.ToString()).FirstOrDefault();
                        var customer = cbbCustomer.Text.ToString();
                        var model = cbbModel.Text.ToString();
                        var maLk = cbbMaLK.Text.ToString();
                        var WO = txbWO.Text.ToString();
                        var QTY = int.Parse(txbQty.Text.ToString());
                        var user = txbUser.Text.ToString();
                        var confirm = txbConfirm.Text.ToString();
                        var typeMachine = cbbMachine.Text.ToString();
                        var MachineCode = txbMachineCode.Text.ToString();
                        var jigCode = txtJigCode.Text.ToString();
                        var dat = dtpDat.Value.Date;
                        if (checksheet != null)
                        {
                            checksheet.Customer = customer;
                            checksheet.Model = model;
                            checksheet.MaLinhKien = maLk;
                            checksheet.WO = WO;
                            checksheet.QTY = QTY;
                            checksheet.CodeUser = user;
                            checksheet.CodeConfirm = confirm;
                            checksheet.Machine = typeMachine;
                            checksheet.MachineCode = MachineCode;
                            checksheet.JigCode = jigCode;
                            checksheet.Dat = dat;
                            checksheet.ModifyDate = DateTime.Now;
                            db.SaveChanges();
                        }
                        else
                        {
                            checksheet = new CHECKSHEET()
                            {
                                Customer = customer,
                                Model = model,
                                MaLinhKien = maLk,
                                WO = WO,
                                QTY = QTY,
                                CodeUser = user,
                                CodeConfirm = confirm,
                                Machine = typeMachine,
                                MachineCode = MachineCode,
                                JigCode = jigCode,
                                Dat = dat,
                                ModifyDate = DateTime.Now
                            };
                            db.CHECKSHEETs.Add(checksheet);
                            db.SaveChanges();
                        }
                        var checksheetHis = new CHECKSHEET_HIS()
                        {
                            Customer = customer,
                            Model = model,
                            MaLinhKien = maLk,
                            WO = WO,
                            QTY = QTY,
                            CodeUser = user,
                            CodeConfirm = confirm,
                            Machine = typeMachine,
                            MachineCode = MachineCode,
                            JigCode = jigCode,
                            Dat = dat,
                            ModifyDate = DateTime.Now
                        };
                        db.CHECKSHEET_HIS.Add(checksheetHis);
                        db.SaveChanges();
                        var list = db.CHECKSHEET_DETAIL.Where(m => m.IdCheckSheet == checksheet.ID).ToList();
                        db.CHECKSHEET_DETAIL.RemoveRange(list);
                        var specA1 = db.SPEC_SETTING.Where(m => m.MaLinhKien == maLk
                                                            && m.Model == model && m.Spec == Constants.A1).FirstOrDefault();
                        var specA2 = db.SPEC_SETTING.Where(m => m.MaLinhKien == maLk
                                                           && m.Model == model && m.Spec == Constants.A2).FirstOrDefault();

                        foreach (DataGridViewRow row in dtgvSpec.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.ColumnIndex > 0 && cell.Value != null)
                                {
                                    var spec = row.Cells[0].Value.ToString();
                                    var specValue = double.Parse(cell.Value.ToString());
                                    if ((spec == Constants.A1 && (specValue > specA1.Max || specValue < specA1.Min))
                                        || (spec == Constants.A2 && (specValue > specA2.Max || specValue < specA2.Min)))
                                    {
                                        MessageBox.Show(dtgvSpec.Columns[cell.ColumnIndex].HeaderText + " giá trị chưa thỏa mãn!");
                                        return;
                                    }
                                    var checkSheetDetail = new CHECKSHEET_DETAIL()
                                    {
                                        IdCheckSheet = checksheet.ID,
                                        Number = cell.ColumnIndex,
                                        Spec = spec,
                                        SpecValue = specValue
                                    };
                                    db.CHECKSHEET_DETAIL.Add(checkSheetDetail);
                                    db.SaveChanges();

                                    db.CHECKSHEET_DETAIL_HIS.Add(new CHECKSHEET_DETAIL_HIS()
                                    {
                                        IdCheckSheet = checksheetHis.ID,
                                        Number = cell.ColumnIndex,
                                        Spec = row.Cells[0].Value.ToString(),
                                        SpecValue = specValue
                                    });
                                    db.SaveChanges();
                                }
                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error occurred.");
                        MessageBox.Show(ex.Message.ToString());
                    }
                }


            }
        }

        private void txbWO_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new E_CHECKSHEETEntities())
                {
                    var WO = txbWO.Text.ToString();
                    var checksheet = db.CHECKSHEETs.Where(m => m.WO == WO).FirstOrDefault();
                    if (checksheet != null)
                    {
                        txbQty.Text = checksheet.QTY.ToString();
                        cbbMaLK.Text = checksheet.MaLinhKien.ToString();
                        txbUser.Text = checksheet.CodeUser;
                        txbConfirm.Text = checksheet.CodeConfirm;
                        dtpDat.Value = checksheet.Dat;
                        cbbMachine.Text = checksheet.Machine;
                        txbMachineCode.Text = checksheet.MachineCode;
                        txtJigCode.Text = checksheet.JigCode;
                        dtgvSpec.Columns.Clear();
                        dtgvSpec.DataSource = null;
                        dtgvSpec.Columns.Add("Column", "Spec");
                        dtgvSpec.Rows.Add(Constants.A1);
                        dtgvSpec.Rows.Add(Constants.A2);
                        var listSpec = db.CHECKSHEET_DETAIL.Where(m => m.IdCheckSheet == checksheet.ID).ToList();
                        var listA1 = listSpec.Where(m => m.Spec == Constants.A1).ToList();
                        var listA2 = listSpec.Where(m => m.Spec == Constants.A2).ToList();
                        var maxA1 = listA1.Max(m => m.Number);
                        var maxA2 = listA2.Max(m => m.Number);
                        var countColumn = dtgvSpec.ColumnCount;
                        var max = maxA1 > maxA2 ? maxA1 : maxA2;

                        for (int i = 0; i < max; i++)
                        {
                            if (countColumn < 6)
                            {
                                dtgvSpec.Columns.Add("Column", "Lần " + countColumn);
                            }
                            else
                            {
                                int index = countColumn - 5;
                                dtgvSpec.Columns.Add("Column", (index * 200).ToString());
                            }
                            countColumn++;
                        }
                        foreach (DataGridViewCell cell in dtgvSpec.Rows[0].Cells)
                        {
                            if (cell.ColumnIndex > 0)
                            {
                                var item = listA1.Where(m => m.Number == cell.ColumnIndex).FirstOrDefault();
                                if (item != null)
                                {
                                    cell.Value = item.SpecValue.ToString();
                                    cell.ReadOnly = true;
                                }

                            }
                        }

                        foreach (DataGridViewCell cell in dtgvSpec.Rows[1].Cells)
                        {
                            if (cell.ColumnIndex > 0)
                            {
                                var item = listA2.Where(m => m.Number == cell.ColumnIndex).FirstOrDefault();
                                if (item != null)
                                {
                                    cell.Value = item.SpecValue.ToString();
                                    cell.ReadOnly = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
