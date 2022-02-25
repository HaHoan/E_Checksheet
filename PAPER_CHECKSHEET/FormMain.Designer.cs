namespace PAPER_CHECKSHEET
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_CHECKSHEETDataSet = new PAPER_CHECKSHEET.E_CHECKSHEETDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbWO = new System.Windows.Forms.TextBox();
            this.txbQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMaLK = new System.Windows.Forms.ComboBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbConfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbMachine = new System.Windows.Forms.ComboBox();
            this.txbMachineCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJigCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgvSpec = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnAddSpec = new System.Windows.Forms.Button();
            this.cUSTOMERTableAdapter = new PAPER_CHECKSHEET.E_CHECKSHEETDataSetTableAdapters.CUSTOMERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_CHECKSHEETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSpec)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(22, 29);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(121, 24);
            this.cbbCustomer.TabIndex = 0;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.e_CHECKSHEETDataSet;
            // 
            // e_CHECKSHEETDataSet
            // 
            this.e_CHECKSHEETDataSet.DataSetName = "E_CHECKSHEETDataSet";
            this.e_CHECKSHEETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách hàng";
            // 
            // cbbModel
            // 
            this.cbbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbModel.FormattingEnabled = true;
            this.cbbModel.Location = new System.Drawing.Point(197, 29);
            this.cbbModel.Name = "cbbModel";
            this.cbbModel.Size = new System.Drawing.Size(121, 24);
            this.cbbModel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "WO";
            // 
            // txbWO
            // 
            this.txbWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWO.Location = new System.Drawing.Point(23, 101);
            this.txbWO.Name = "txbWO";
            this.txbWO.Size = new System.Drawing.Size(117, 22);
            this.txbWO.TabIndex = 5;
            this.txbWO.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbWO_PreviewKeyDown);
            // 
            // txbQty
            // 
            this.txbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQty.Location = new System.Drawing.Point(150, 101);
            this.txbQty.Name = "txbQty";
            this.txbQty.Size = new System.Drawing.Size(121, 22);
            this.txbQty.TabIndex = 7;
            this.txbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumberPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "QTY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã link kiện";
            // 
            // cbbMaLK
            // 
            this.cbbMaLK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaLK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLK.FormattingEnabled = true;
            this.cbbMaLK.Location = new System.Drawing.Point(372, 28);
            this.cbbMaLK.Name = "cbbMaLK";
            this.cbbMaLK.Size = new System.Drawing.Size(137, 24);
            this.cbbMaLK.TabIndex = 8;
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(282, 101);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(108, 22);
            this.txbUser.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "User";
            // 
            // txbConfirm
            // 
            this.txbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirm.Location = new System.Drawing.Point(398, 101);
            this.txbConfirm.Name = "txbConfirm";
            this.txbConfirm.Size = new System.Drawing.Size(111, 22);
            this.txbConfirm.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Confirm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dat";
            // 
            // dtpDat
            // 
            this.dtpDat.CustomFormat = "dd/mm/yyyy";
            this.dtpDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDat.Location = new System.Drawing.Point(395, 172);
            this.dtpDat.Name = "dtpDat";
            this.dtpDat.Size = new System.Drawing.Size(119, 22);
            this.dtpDat.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Loại máy gia công";
            // 
            // cbbMachine
            // 
            this.cbbMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMachine.FormattingEnabled = true;
            this.cbbMachine.Location = new System.Drawing.Point(23, 172);
            this.cbbMachine.Name = "cbbMachine";
            this.cbbMachine.Size = new System.Drawing.Size(121, 24);
            this.cbbMachine.TabIndex = 16;
            // 
            // txbMachineCode
            // 
            this.txbMachineCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMachineCode.Location = new System.Drawing.Point(150, 172);
            this.txbMachineCode.Name = "txbMachineCode";
            this.txbMachineCode.Size = new System.Drawing.Size(124, 22);
            this.txbMachineCode.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Machine code";
            // 
            // txtJigCode
            // 
            this.txtJigCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJigCode.Location = new System.Drawing.Point(282, 172);
            this.txtJigCode.Name = "txtJigCode";
            this.txtJigCode.Size = new System.Drawing.Size(108, 22);
            this.txtJigCode.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Jig code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "QUY CÁCH";
            // 
            // dtgvSpec
            // 
            this.dtgvSpec.AllowUserToAddRows = false;
            this.dtgvSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSpec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvSpec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSpec.GridColor = System.Drawing.Color.Black;
            this.dtgvSpec.Location = new System.Drawing.Point(29, 249);
            this.dtgvSpec.Name = "dtgvSpec";
            this.dtgvSpec.RowHeadersVisible = false;
            this.dtgvSpec.Size = new System.Drawing.Size(847, 98);
            this.dtgvSpec.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(275, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 39);
            this.label13.TabIndex = 26;
            this.label13.Text = "E-CHECKSHEET";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetting.Image = global::PAPER_CHECKSHEET.Properties.Resources.icon_setting;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(787, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(89, 40);
            this.btnSetting.TabIndex = 29;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF.Image = global::PAPER_CHECKSHEET.Properties.Resources.icon_pdf;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(682, 12);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(89, 40);
            this.btnPDF.TabIndex = 28;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveChanges.Image = global::PAPER_CHECKSHEET.Properties.Resources.icon_save;
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.Location = new System.Drawing.Point(585, 13);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(80, 40);
            this.btnSaveChanges.TabIndex = 27;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnAddSpec
            // 
            this.btnAddSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSpec.Image = global::PAPER_CHECKSHEET.Properties.Resources.icon_plus;
            this.btnAddSpec.Location = new System.Drawing.Point(102, 202);
            this.btnAddSpec.Name = "btnAddSpec";
            this.btnAddSpec.Size = new System.Drawing.Size(38, 41);
            this.btnAddSpec.TabIndex = 24;
            this.btnAddSpec.UseVisualStyleBackColor = true;
            this.btnAddSpec.Click += new System.EventHandler(this.btnAddSpec_Click);
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 452);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAddSpec);
            this.Controls.Add(this.dtgvSpec);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtJigCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbMachineCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbMachine);
            this.Controls.Add(this.dtpDat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbMaLK);
            this.Controls.Add(this.txbQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbWO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCustomer);
            this.Name = "FormMain";
            this.Text = "E-CHECKSHEET";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_CHECKSHEETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSpec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbWO;
        private System.Windows.Forms.TextBox txbQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaLK;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbMachine;
        private System.Windows.Forms.TextBox txbMachineCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJigCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgvSpec;
        private System.Windows.Forms.Button btnAddSpec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnSetting;
        private E_CHECKSHEETDataSet e_CHECKSHEETDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private E_CHECKSHEETDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
    }
}

