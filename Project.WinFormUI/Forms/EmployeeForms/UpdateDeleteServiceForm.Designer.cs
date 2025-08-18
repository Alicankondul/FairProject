namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class UpdateDeleteServiceForm
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
            this.GrpProviderDetails = new System.Windows.Forms.GroupBox();
            this.GrpServiceDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LstServices = new System.Windows.Forms.ListBox();
            this.BtnUpdateService = new System.Windows.Forms.Button();
            this.BtnDeleteService = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtProviderName = new System.Windows.Forms.TextBox();
            this.TxtProviderAddress = new System.Windows.Forms.TextBox();
            this.TxtProviderCity = new System.Windows.Forms.TextBox();
            this.TxtProviderDistrict = new System.Windows.Forms.TextBox();
            this.TxtProviderPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtProviderEmail = new System.Windows.Forms.TextBox();
            this.TxtDescriptorName = new System.Windows.Forms.TextBox();
            this.TxtDescriptorDescription = new System.Windows.Forms.TextBox();
            this.TxtValueName = new System.Windows.Forms.TextBox();
            this.NudCost = new System.Windows.Forms.NumericUpDown();
            this.NudPreparationTime = new System.Windows.Forms.NumericUpDown();
            this.NudBufferTime = new System.Windows.Forms.NumericUpDown();
            this.GrpProviderDetails.SuspendLayout();
            this.GrpServiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPreparationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBufferTime)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpProviderDetails
            // 
            this.GrpProviderDetails.Controls.Add(this.TxtProviderEmail);
            this.GrpProviderDetails.Controls.Add(this.TxtProviderPhoneNumber);
            this.GrpProviderDetails.Controls.Add(this.TxtProviderDistrict);
            this.GrpProviderDetails.Controls.Add(this.TxtProviderCity);
            this.GrpProviderDetails.Controls.Add(this.TxtProviderAddress);
            this.GrpProviderDetails.Controls.Add(this.TxtProviderName);
            this.GrpProviderDetails.Controls.Add(this.label12);
            this.GrpProviderDetails.Controls.Add(this.label7);
            this.GrpProviderDetails.Controls.Add(this.label8);
            this.GrpProviderDetails.Controls.Add(this.label11);
            this.GrpProviderDetails.Controls.Add(this.label9);
            this.GrpProviderDetails.Controls.Add(this.label10);
            this.GrpProviderDetails.Location = new System.Drawing.Point(16, 426);
            this.GrpProviderDetails.Name = "GrpProviderDetails";
            this.GrpProviderDetails.Size = new System.Drawing.Size(448, 252);
            this.GrpProviderDetails.TabIndex = 0;
            this.GrpProviderDetails.TabStop = false;
            this.GrpProviderDetails.Text = "Sağlayıcı Bilgileri";
            // 
            // GrpServiceDetails
            // 
            this.GrpServiceDetails.Controls.Add(this.NudBufferTime);
            this.GrpServiceDetails.Controls.Add(this.NudPreparationTime);
            this.GrpServiceDetails.Controls.Add(this.NudCost);
            this.GrpServiceDetails.Controls.Add(this.label6);
            this.GrpServiceDetails.Controls.Add(this.label1);
            this.GrpServiceDetails.Controls.Add(this.label5);
            this.GrpServiceDetails.Controls.Add(this.label2);
            this.GrpServiceDetails.Controls.Add(this.label4);
            this.GrpServiceDetails.Controls.Add(this.TxtValueName);
            this.GrpServiceDetails.Controls.Add(this.TxtDescriptorDescription);
            this.GrpServiceDetails.Controls.Add(this.TxtDescriptorName);
            this.GrpServiceDetails.Controls.Add(this.label3);
            this.GrpServiceDetails.Location = new System.Drawing.Point(487, 426);
            this.GrpServiceDetails.Name = "GrpServiceDetails";
            this.GrpServiceDetails.Size = new System.Drawing.Size(448, 252);
            this.GrpServiceDetails.TabIndex = 0;
            this.GrpServiceDetails.TabStop = false;
            this.GrpServiceDetails.Text = "Hizmet Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hizmet Tanımı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hizmet Açıklaması :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hizmet Değer Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maliyet (₺) : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hazırlık Süresi (gün) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tampon Süresi (gün) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sağlayıcı Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Adres :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "İl :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "İlçe :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Telefon :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "E-Mail :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(346, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(488, 28);
            this.label13.TabIndex = 2;
            this.label13.Text = "EK HİZMET BİLGİLERİNİ GÜNCELLE VE SİL";
            // 
            // LstServices
            // 
            this.LstServices.FormattingEnabled = true;
            this.LstServices.ItemHeight = 16;
            this.LstServices.Location = new System.Drawing.Point(16, 127);
            this.LstServices.Name = "LstServices";
            this.LstServices.Size = new System.Drawing.Size(1091, 276);
            this.LstServices.TabIndex = 3;
            this.LstServices.SelectedIndexChanged += new System.EventHandler(this.LstServices_SelectedIndexChanged);
            // 
            // BtnUpdateService
            // 
            this.BtnUpdateService.Location = new System.Drawing.Point(977, 426);
            this.BtnUpdateService.Name = "BtnUpdateService";
            this.BtnUpdateService.Size = new System.Drawing.Size(130, 31);
            this.BtnUpdateService.TabIndex = 4;
            this.BtnUpdateService.Text = "Hizmeti Güncelle";
            this.BtnUpdateService.UseVisualStyleBackColor = true;
            this.BtnUpdateService.Click += new System.EventHandler(this.BtnUpdateService_Click);
            // 
            // BtnDeleteService
            // 
            this.BtnDeleteService.Location = new System.Drawing.Point(977, 463);
            this.BtnDeleteService.Name = "BtnDeleteService";
            this.BtnDeleteService.Size = new System.Drawing.Size(130, 31);
            this.BtnDeleteService.TabIndex = 4;
            this.BtnDeleteService.Text = "Hizmeti Sil";
            this.BtnDeleteService.UseVisualStyleBackColor = true;
            this.BtnDeleteService.Click += new System.EventHandler(this.BtnDeleteService_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(977, 500);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(130, 31);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "İptal";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtProviderName
            // 
            this.TxtProviderName.Location = new System.Drawing.Point(104, 36);
            this.TxtProviderName.Name = "TxtProviderName";
            this.TxtProviderName.Size = new System.Drawing.Size(308, 22);
            this.TxtProviderName.TabIndex = 3;
            // 
            // TxtProviderAddress
            // 
            this.TxtProviderAddress.Location = new System.Drawing.Point(104, 70);
            this.TxtProviderAddress.Name = "TxtProviderAddress";
            this.TxtProviderAddress.Size = new System.Drawing.Size(308, 22);
            this.TxtProviderAddress.TabIndex = 3;
            // 
            // TxtProviderCity
            // 
            this.TxtProviderCity.Location = new System.Drawing.Point(104, 104);
            this.TxtProviderCity.Name = "TxtProviderCity";
            this.TxtProviderCity.Size = new System.Drawing.Size(308, 22);
            this.TxtProviderCity.TabIndex = 3;
            // 
            // TxtProviderDistrict
            // 
            this.TxtProviderDistrict.Location = new System.Drawing.Point(104, 134);
            this.TxtProviderDistrict.Name = "TxtProviderDistrict";
            this.TxtProviderDistrict.Size = new System.Drawing.Size(308, 22);
            this.TxtProviderDistrict.TabIndex = 3;
            // 
            // TxtProviderPhoneNumber
            // 
            this.TxtProviderPhoneNumber.Location = new System.Drawing.Point(104, 165);
            this.TxtProviderPhoneNumber.Name = "TxtProviderPhoneNumber";
            this.TxtProviderPhoneNumber.Size = new System.Drawing.Size(308, 22);
            this.TxtProviderPhoneNumber.TabIndex = 3;
            // 
            // TxtProviderEmail
            // 
            this.TxtProviderEmail.Location = new System.Drawing.Point(104, 197);
            this.TxtProviderEmail.Name = "TxtProviderEmail";
            this.TxtProviderEmail.Size = new System.Drawing.Size(308, 22);
            this.TxtProviderEmail.TabIndex = 3;
            // 
            // TxtDescriptorName
            // 
            this.TxtDescriptorName.Location = new System.Drawing.Point(159, 37);
            this.TxtDescriptorName.Name = "TxtDescriptorName";
            this.TxtDescriptorName.Size = new System.Drawing.Size(283, 22);
            this.TxtDescriptorName.TabIndex = 3;
            // 
            // TxtDescriptorDescription
            // 
            this.TxtDescriptorDescription.Location = new System.Drawing.Point(159, 70);
            this.TxtDescriptorDescription.Name = "TxtDescriptorDescription";
            this.TxtDescriptorDescription.Size = new System.Drawing.Size(283, 22);
            this.TxtDescriptorDescription.TabIndex = 3;
            // 
            // TxtValueName
            // 
            this.TxtValueName.Location = new System.Drawing.Point(159, 104);
            this.TxtValueName.Name = "TxtValueName";
            this.TxtValueName.Size = new System.Drawing.Size(283, 22);
            this.TxtValueName.TabIndex = 3;
            // 
            // NudCost
            // 
            this.NudCost.Location = new System.Drawing.Point(159, 135);
            this.NudCost.Name = "NudCost";
            this.NudCost.Size = new System.Drawing.Size(283, 22);
            this.NudCost.TabIndex = 4;
            // 
            // NudPreparationTime
            // 
            this.NudPreparationTime.Location = new System.Drawing.Point(159, 166);
            this.NudPreparationTime.Name = "NudPreparationTime";
            this.NudPreparationTime.Size = new System.Drawing.Size(283, 22);
            this.NudPreparationTime.TabIndex = 4;
            // 
            // NudBufferTime
            // 
            this.NudBufferTime.Location = new System.Drawing.Point(159, 200);
            this.NudBufferTime.Name = "NudBufferTime";
            this.NudBufferTime.Size = new System.Drawing.Size(283, 22);
            this.NudBufferTime.TabIndex = 4;
            // 
            // UpdateDeleteServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 713);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDeleteService);
            this.Controls.Add(this.BtnUpdateService);
            this.Controls.Add(this.LstServices);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GrpServiceDetails);
            this.Controls.Add(this.GrpProviderDetails);
            this.Name = "UpdateDeleteServiceForm";
            this.Text = "Hizmet Güncelle/Sil";
            this.GrpProviderDetails.ResumeLayout(false);
            this.GrpProviderDetails.PerformLayout();
            this.GrpServiceDetails.ResumeLayout(false);
            this.GrpServiceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPreparationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBufferTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpProviderDetails;
        private System.Windows.Forms.GroupBox GrpServiceDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox LstServices;
        private System.Windows.Forms.Button BtnUpdateService;
        private System.Windows.Forms.Button BtnDeleteService;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtProviderEmail;
        private System.Windows.Forms.TextBox TxtProviderPhoneNumber;
        private System.Windows.Forms.TextBox TxtProviderDistrict;
        private System.Windows.Forms.TextBox TxtProviderCity;
        private System.Windows.Forms.TextBox TxtProviderAddress;
        private System.Windows.Forms.TextBox TxtProviderName;
        private System.Windows.Forms.NumericUpDown NudCost;
        private System.Windows.Forms.TextBox TxtValueName;
        private System.Windows.Forms.TextBox TxtDescriptorDescription;
        private System.Windows.Forms.TextBox TxtDescriptorName;
        private System.Windows.Forms.NumericUpDown NudBufferTime;
        private System.Windows.Forms.NumericUpDown NudPreparationTime;
    }
}