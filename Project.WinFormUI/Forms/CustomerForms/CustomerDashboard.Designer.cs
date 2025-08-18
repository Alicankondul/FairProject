namespace Project.WinFormUI.Forms.CustomerForms
{
    partial class CustomerDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LstBuildings = new System.Windows.Forms.ListBox();
            this.BtnRequestBuilding = new System.Windows.Forms.Button();
            this.BtnConfirmFair = new System.Windows.Forms.Button();
            this.BtnSearchBuildings = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblBuildingDetails = new System.Windows.Forms.Label();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.TxtFairName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.BtnCancelFair = new System.Windows.Forms.Button();
            this.BtnViewFairDetails = new System.Windows.Forms.Button();
            this.DgvFairs = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFairs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 512);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LstBuildings);
            this.tabPage1.Controls.Add(this.BtnRequestBuilding);
            this.tabPage1.Controls.Add(this.BtnConfirmFair);
            this.tabPage1.Controls.Add(this.BtnSearchBuildings);
            this.tabPage1.Controls.Add(this.BtnCancel);
            this.tabPage1.Controls.Add(this.LblBuildingDetails);
            this.tabPage1.Controls.Add(this.DtpEndDate);
            this.tabPage1.Controls.Add(this.DtpStartDate);
            this.tabPage1.Controls.Add(this.CmbDistrict);
            this.tabPage1.Controls.Add(this.CmbCity);
            this.tabPage1.Controls.Add(this.TxtFairName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1002, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fuar Oluştur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LstBuildings
            // 
            this.LstBuildings.FormattingEnabled = true;
            this.LstBuildings.ItemHeight = 16;
            this.LstBuildings.Location = new System.Drawing.Point(480, 61);
            this.LstBuildings.Name = "LstBuildings";
            this.LstBuildings.Size = new System.Drawing.Size(489, 308);
            this.LstBuildings.TabIndex = 6;
            this.LstBuildings.SelectedIndexChanged += new System.EventHandler(this.LstBuildings_SelectedIndexChanged);
            // 
            // BtnRequestBuilding
            // 
            this.BtnRequestBuilding.Location = new System.Drawing.Point(621, 420);
            this.BtnRequestBuilding.Name = "BtnRequestBuilding";
            this.BtnRequestBuilding.Size = new System.Drawing.Size(145, 23);
            this.BtnRequestBuilding.TabIndex = 5;
            this.BtnRequestBuilding.Text = "Özel Bina Talebi";
            this.BtnRequestBuilding.UseVisualStyleBackColor = true;
            this.BtnRequestBuilding.Click += new System.EventHandler(this.BtnRequestBuilding_Click);
            // 
            // BtnConfirmFair
            // 
            this.BtnConfirmFair.Location = new System.Drawing.Point(803, 420);
            this.BtnConfirmFair.Name = "BtnConfirmFair";
            this.BtnConfirmFair.Size = new System.Drawing.Size(145, 23);
            this.BtnConfirmFair.TabIndex = 5;
            this.BtnConfirmFair.Text = "Seçimi Onayla";
            this.BtnConfirmFair.UseVisualStyleBackColor = true;
            this.BtnConfirmFair.Click += new System.EventHandler(this.BtnConfirmFair_Click);
            // 
            // BtnSearchBuildings
            // 
            this.BtnSearchBuildings.Location = new System.Drawing.Point(314, 271);
            this.BtnSearchBuildings.Name = "BtnSearchBuildings";
            this.BtnSearchBuildings.Size = new System.Drawing.Size(109, 23);
            this.BtnSearchBuildings.TabIndex = 5;
            this.BtnSearchBuildings.Text = "Gönder";
            this.BtnSearchBuildings.UseVisualStyleBackColor = true;
            this.BtnSearchBuildings.Click += new System.EventHandler(this.BtnSearchBuildings_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(205, 271);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(103, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblBuildingDetails
            // 
            this.LblBuildingDetails.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LblBuildingDetails.Location = new System.Drawing.Point(21, 326);
            this.LblBuildingDetails.Name = "LblBuildingDetails";
            this.LblBuildingDetails.Size = new System.Drawing.Size(402, 142);
            this.LblBuildingDetails.TabIndex = 4;
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.Location = new System.Drawing.Point(122, 230);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(301, 22);
            this.DtpEndDate.TabIndex = 3;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Location = new System.Drawing.Point(122, 189);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(301, 22);
            this.DtpStartDate.TabIndex = 3;
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(122, 147);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(176, 24);
            this.CmbDistrict.TabIndex = 2;
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(122, 102);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(176, 24);
            this.CmbCity.TabIndex = 2;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // TxtFairName
            // 
            this.TxtFairName.Location = new System.Drawing.Point(122, 61);
            this.TxtFairName.Name = "TxtFairName";
            this.TxtFairName.Size = new System.Drawing.Size(176, 22);
            this.TxtFairName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seçilen Bina Özellikleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bitiş Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Başlangıç Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "İlçe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "İl : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fuar Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUAR OLUŞTUR";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnIptal);
            this.tabPage2.Controls.Add(this.BtnCancelFair);
            this.tabPage2.Controls.Add(this.BtnViewFairDetails);
            this.tabPage2.Controls.Add(this.DgvFairs);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1002, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fuarlarım";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(446, 428);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(119, 32);
            this.BtnIptal.TabIndex = 1;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // BtnCancelFair
            // 
            this.BtnCancelFair.Location = new System.Drawing.Point(446, 390);
            this.BtnCancelFair.Name = "BtnCancelFair";
            this.BtnCancelFair.Size = new System.Drawing.Size(119, 32);
            this.BtnCancelFair.TabIndex = 1;
            this.BtnCancelFair.Text = "Fuarı İptal Et";
            this.BtnCancelFair.UseVisualStyleBackColor = true;
            this.BtnCancelFair.Click += new System.EventHandler(this.BtnCancelFair_Click);
            // 
            // BtnViewFairDetails
            // 
            this.BtnViewFairDetails.Location = new System.Drawing.Point(446, 352);
            this.BtnViewFairDetails.Name = "BtnViewFairDetails";
            this.BtnViewFairDetails.Size = new System.Drawing.Size(119, 32);
            this.BtnViewFairDetails.TabIndex = 1;
            this.BtnViewFairDetails.Text = "Fuar Detayları";
            this.BtnViewFairDetails.UseVisualStyleBackColor = true;
            this.BtnViewFairDetails.Click += new System.EventHandler(this.BtnViewFairDetails_Click);
            // 
            // DgvFairs
            // 
            this.DgvFairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFairs.Location = new System.Drawing.Point(19, 21);
            this.DgvFairs.Name = "DgvFairs";
            this.DgvFairs.RowHeadersWidth = 51;
            this.DgvFairs.RowTemplate.Height = 24;
            this.DgvFairs.Size = new System.Drawing.Size(960, 325);
            this.DgvFairs.TabIndex = 0;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblBuildingDetails;
        private System.Windows.Forms.DateTimePicker DtpEndDate;
        private System.Windows.Forms.DateTimePicker DtpStartDate;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.TextBox TxtFairName;
        private System.Windows.Forms.ListBox LstBuildings;
        private System.Windows.Forms.Button BtnRequestBuilding;
        private System.Windows.Forms.Button BtnConfirmFair;
        private System.Windows.Forms.Button BtnSearchBuildings;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridView DgvFairs;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Button BtnCancelFair;
        private System.Windows.Forms.Button BtnViewFairDetails;
    }
}