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
    public partial class FormSetting : Form
    {
        public Action ActionClosed;

        public FormSetting()
        {
            InitializeComponent();
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
                var listModel = db.MODELs.ToList();
                cbbModel.DataSource = listModel;
                cbbModel.DisplayMember = "ModelName";
                var listLK = db.MALINHKIENs.ToList();
                cbbMaLK.DataSource = listLK;
                cbbMaLK.DisplayMember = "MaLinhKien1";
            }
        }
        private void btnSaveMaLK_Click(object sender, EventArgs e)
        {
            using (var db = new E_CHECKSHEETEntities())
            {
                var maLK = txbMaLK.Text.Trim();
                if (string.IsNullOrEmpty(maLK))
                {
                    MessageBox.Show("Bạn phải nhập  mã linh kiện!");
                }
                else
                {
                    var maLKDB = db.MALINHKIENs.Where(m => m.MaLinhKien1 == maLK).FirstOrDefault();
                    if (maLKDB != null)
                    {
                        MessageBox.Show("Đã thêm mã linh kiện này rồi!");
                    }
                    else
                    {
                        db.MALINHKIENs.Add(new MALINHKIEN()
                        {
                            MaLinhKien1 = maLK
                        });
                        db.SaveChanges();
                        MessageBox.Show("Đã thêm thành công!");
                        addToCombobox();
                    }
                }
            }


        }

        private void btnSaveSpec_Click(object sender, EventArgs e)
        {
            using (var db = new E_CHECKSHEETEntities())
            {
                using (DbContextTransaction transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var model = cbbModel.Text;
                        var malinhkien = cbbMaLK.Text;
                        var specA1 = db.SPEC_SETTING.Where(m => m.Model == model
                        && m.MaLinhKien == malinhkien && m.Spec == Constants.A1).FirstOrDefault();
                        if (specA1 != null)
                        {
                            specA1.Model = cbbModel.Text;
                            specA1.MaLinhKien = cbbMaLK.Text;
                            specA1.Spec = Constants.A1;
                            specA1.Min = double.Parse(txbMinA1.Text);
                            specA1.Max = double.Parse(txbMaxA1.Text);
                        }
                        else
                        {
                            specA1 = new SPEC_SETTING()
                            {
                                Model = cbbModel.Text,
                                MaLinhKien = cbbMaLK.Text,
                                Spec = Constants.A1,
                                Min = double.Parse(txbMinA1.Text),
                                Max = double.Parse(txbMaxA1.Text)
                            };
                            db.SPEC_SETTING.Add(specA1);
                        }
                        db.SaveChanges();
                        var specA2 = db.SPEC_SETTING.Where(m => m.Model == model
                        && m.MaLinhKien == malinhkien && m.Spec == Constants.A2).FirstOrDefault();
                        if (specA2 != null)
                        {
                            specA2.Model = cbbModel.Text;
                            specA2.MaLinhKien = cbbMaLK.Text;
                            specA2.Spec = Constants.A2;
                            specA2.Min = double.Parse(txbMinA2.Text);
                            specA2.Max = double.Parse(txbMaxA2.Text);
                        }
                        else
                        {
                            specA2 = new SPEC_SETTING()
                            {
                                Model = cbbModel.Text,
                                MaLinhKien = cbbMaLK.Text,
                                Spec = Constants.A2,
                                Min = double.Parse(txbMinA2.Text),
                                Max = double.Parse(txbMaxA2.Text)
                            };
                            db.SPEC_SETTING.Add(specA2);
                        }
                        db.SaveChanges();
                        transaction.Commit();
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message.ToString());
                    }

                }

            }
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            using (var db = new E_CHECKSHEETEntities())
            {
                var model = txbModel.Text.Trim();
                if (string.IsNullOrEmpty(model))
                {
                    MessageBox.Show("Bạn phải nhập  model!");
                    txbModel.Focus();
                }
                else
                {
                    var modelDB = db.MODELs.Where(m => m.ModelName == model).FirstOrDefault();
                    if (modelDB != null)
                    {
                        MessageBox.Show("Đã thêm model này rồi!");
                    }
                    else
                    {
                        db.MODELs.Add(new MODEL()
                        {
                            ModelName = model
                        });
                        db.SaveChanges();
                        MessageBox.Show("Đã thêm thành công!");
                        addToCombobox();
                    }
                }
            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            using (var db = new E_CHECKSHEETEntities())
            {
                var customer = txbCustomer.Text.Trim();
                if (string.IsNullOrEmpty(customer))
                {
                    MessageBox.Show("Bạn phải nhập  tên khách hàng!");
                    txbCustomer.Focus();
                }
                else
                {
                    var customerDB = db.CUSTOMERs.Where(m => m.CustomerName == customer).FirstOrDefault();
                    if (customerDB != null)
                    {
                        MessageBox.Show("Đã thêm khách hàng này rồi!");

                    }
                    else
                    {
                        db.CUSTOMERs.Add(new CUSTOMER()
                        {
                            CustomerName = customer
                        });
                        db.SaveChanges();
                        MessageBox.Show("Đã thêm thành công!");
                        txbCustomer.SelectAll();
                    }
                }
            }

        }

        private void FormSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActionClosed();
        }

        private void cbbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSpec();
        }

        private void cbbMaLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSpec();
        }

        private void updateSpec()
        {
            try
            {
                using (var db = new E_CHECKSHEETEntities())
                {
                    var model = cbbModel.Text;
                    var malinhkien = cbbMaLK.Text;
                    var specA1 = db.SPEC_SETTING.Where(m => m.Model == model
                    && m.MaLinhKien == malinhkien && m.Spec == Constants.A1).FirstOrDefault();
                    if (specA1 != null)
                    {
                        txbMinA1.Text = specA1.Min.ToString();
                        txbMaxA1.Text = specA1.Max.ToString();
                    }
                    else
                    {
                        txbMinA1.Text = "";
                        txbMaxA1.Text = "";
                    }
                    var specA2 = db.SPEC_SETTING.Where(m => m.Model == model
                    && m.MaLinhKien == malinhkien && m.Spec == Constants.A2).FirstOrDefault();
                    if (specA2 != null)
                    {
                        txbMinA2.Text = specA2.Min.ToString();
                        txbMaxA2.Text = specA2.Max.ToString();
                    }
                    else
                    {
                        txbMinA2.Text = "";
                        txbMaxA2.Text = "";
                    }
                }

            }
            catch (Exception e)
            {

            }



        }
    }
}
