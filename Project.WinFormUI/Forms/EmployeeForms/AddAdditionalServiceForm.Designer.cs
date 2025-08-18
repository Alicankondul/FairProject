namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class AddAdditionalServiceForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.ChkNewProvider = new System.Windows.Forms.CheckBox();
            this.CmbExistingProviders = new System.Windows.Forms.ComboBox();
            this.TxtDescriptorName = new System.Windows.Forms.TextBox();
            this.TxtDescriptorDescription = new System.Windows.Forms.TextBox();
            this.TxtValueName = new System.Windows.Forms.TextBox();
            this.TxtProviderName = new System.Windows.Forms.TextBox();
            this.TxtProviderAddress = new System.Windows.Forms.TextBox();
            this.TxtProviderCity = new System.Windows.Forms.TextBox();
            this.TxtProviderDistrict = new System.Windows.Forms.TextBox();
            this.TxtProviderPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtProviderEmail = new System.Windows.Forms.TextBox();
            this.NudCost = new System.Windows.Forms.NumericUpDown();
            this.NudPreparationTime = new System.Windows.Forms.NumericUpDown();
            this.NudBufferTime = new System.Windows.Forms.NumericUpDown();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddService = new System.Windows.Forms.Button();
            this.LstServices = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPreparationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBufferTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(432, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "HİZMET EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mevcut Firmaya Ekleme Yap :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hizmet Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hizmet Açıklaması :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hizmet Değer Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maliyet(₺) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hazırlık Süresi(Gün) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sağlayıcı Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tampon Süresi(Gün) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Adres :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Şehir :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "İlçe :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Telefon Numarası :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "E-Posta :";
            // 
            // ChkNewProvider
            // 
            this.ChkNewProvider.AutoSize = true;
            this.ChkNewProvider.Location = new System.Drawing.Point(25, 93);
            this.ChkNewProvider.Name = "ChkNewProvider";
            this.ChkNewProvider.Size = new System.Drawing.Size(123, 20);
            this.ChkNewProvider.TabIndex = 1;
            this.ChkNewProvider.Text = "Yeni Firma Ekle";
            this.ChkNewProvider.UseVisualStyleBackColor = true;
            this.ChkNewProvider.CheckedChanged += new System.EventHandler(this.ChkNewProvider_CheckedChanged);
            // 
            // CmbExistingProviders
            // 
            this.CmbExistingProviders.FormattingEnabled = true;
            this.CmbExistingProviders.Location = new System.Drawing.Point(610, 90);
            this.CmbExistingProviders.Name = "CmbExistingProviders";
            this.CmbExistingProviders.Size = new System.Drawing.Size(187, 24);
            this.CmbExistingProviders.TabIndex = 2;
            this.CmbExistingProviders.SelectedIndexChanged += new System.EventHandler(this.CmbExistingProviders_SelectedIndexChanged);
            // 
            // TxtDescriptorName
            // 
            this.TxtDescriptorName.Location = new System.Drawing.Point(193, 137);
            this.TxtDescriptorName.Name = "TxtDescriptorName";
            this.TxtDescriptorName.Size = new System.Drawing.Size(302, 22);
            this.TxtDescriptorName.TabIndex = 3;
            // 
            // TxtDescriptorDescription
            // 
            this.TxtDescriptorDescription.Location = new System.Drawing.Point(193, 175);
            this.TxtDescriptorDescription.Name = "TxtDescriptorDescription";
            this.TxtDescriptorDescription.Size = new System.Drawing.Size(302, 22);
            this.TxtDescriptorDescription.TabIndex = 3;
            // 
            // TxtValueName
            // 
            this.TxtValueName.Location = new System.Drawing.Point(193, 208);
            this.TxtValueName.Name = "TxtValueName";
            this.TxtValueName.Size = new System.Drawing.Size(302, 22);
            this.TxtValueName.TabIndex = 3;
            // 
            // TxtProviderName
            // 
            this.TxtProviderName.Location = new System.Drawing.Point(193, 340);
            this.TxtProviderName.Name = "TxtProviderName";
            this.TxtProviderName.Size = new System.Drawing.Size(302, 22);
            this.TxtProviderName.TabIndex = 3;
            // 
            // TxtProviderAddress
            // 
            this.TxtProviderAddress.Location = new System.Drawing.Point(193, 372);
            this.TxtProviderAddress.Name = "TxtProviderAddress";
            this.TxtProviderAddress.Size = new System.Drawing.Size(302, 22);
            this.TxtProviderAddress.TabIndex = 3;
            // 
            // TxtProviderCity
            // 
            this.TxtProviderCity.Location = new System.Drawing.Point(193, 399);
            this.TxtProviderCity.Name = "TxtProviderCity";
            this.TxtProviderCity.Size = new System.Drawing.Size(302, 22);
            this.TxtProviderCity.TabIndex = 3;
            // 
            // TxtProviderDistrict
            // 
            this.TxtProviderDistrict.Location = new System.Drawing.Point(193, 432);
            this.TxtProviderDistrict.Name = "TxtProviderDistrict";
            this.TxtProviderDistrict.Size = new System.Drawing.Size(302, 22);
            this.TxtProviderDistrict.TabIndex = 3;
            // 
            // TxtProviderPhoneNumber
            // 
            this.TxtProviderPhoneNumber.Location = new System.Drawing.Point(193, 462);
            this.TxtProviderPhoneNumber.Name = "TxtProviderPhoneNumber";
            this.TxtProviderPhoneNumber.Size = new System.Drawing.Size(302, 22);
            this.TxtProviderPhoneNumber.TabIndex = 3;
            // 
            // TxtProviderEmail
            // 
            this.TxtProviderEmail.Location = new System.Drawing.Point(193, 492);
            this.TxtProviderEmail.Name = "TxtProviderEmail";
            this.TxtProviderEmail.Size = new System.Drawing.Size(302, 22);
            this.TxtProviderEmail.TabIndex = 3;
            // 
            // NudCost
            // 
            this.NudCost.Location = new System.Drawing.Point(193, 238);
            this.NudCost.Name = "NudCost";
            this.NudCost.Size = new System.Drawing.Size(302, 22);
            this.NudCost.TabIndex = 4;
            // 
            // NudPreparationTime
            // 
            this.NudPreparationTime.Location = new System.Drawing.Point(193, 271);
            this.NudPreparationTime.Name = "NudPreparationTime";
            this.NudPreparationTime.Size = new System.Drawing.Size(302, 22);
            this.NudPreparationTime.TabIndex = 4;
            // 
            // NudBufferTime
            // 
            this.NudBufferTime.Location = new System.Drawing.Point(193, 304);
            this.NudBufferTime.Name = "NudBufferTime";
            this.NudBufferTime.Size = new System.Drawing.Size(302, 22);
            this.NudBufferTime.TabIndex = 4;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(193, 537);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(109, 24);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "İptal";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddService
            // 
            this.BtnAddService.Location = new System.Drawing.Point(343, 537);
            this.BtnAddService.Name = "BtnAddService";
            this.BtnAddService.Size = new System.Drawing.Size(109, 24);
            this.BtnAddService.TabIndex = 5;
            this.BtnAddService.Text = "Hizmet Ekle";
            this.BtnAddService.UseVisualStyleBackColor = true;
            this.BtnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // LstServices
            // 
            this.LstServices.HideSelection = false;
            this.LstServices.Location = new System.Drawing.Point(531, 133);
            this.LstServices.Name = "LstServices";
            this.LstServices.Size = new System.Drawing.Size(614, 449);
            this.LstServices.TabIndex = 6;
            this.LstServices.UseCompatibleStateImageBehavior = false;
            // 
            // AddAdditionalServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 594);
            this.Controls.Add(this.LstServices);
            this.Controls.Add(this.BtnAddService);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.NudBufferTime);
            this.Controls.Add(this.NudPreparationTime);
            this.Controls.Add(this.NudCost);
            this.Controls.Add(this.TxtProviderEmail);
            this.Controls.Add(this.TxtProviderPhoneNumber);
            this.Controls.Add(this.TxtProviderDistrict);
            this.Controls.Add(this.TxtProviderCity);
            this.Controls.Add(this.TxtProviderAddress);
            this.Controls.Add(this.TxtProviderName);
            this.Controls.Add(this.TxtValueName);
            this.Controls.Add(this.TxtDescriptorDescription);
            this.Controls.Add(this.TxtDescriptorName);
            this.Controls.Add(this.CmbExistingProviders);
            this.Controls.Add(this.ChkNewProvider);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAdditionalServiceForm";
            this.Text = "AddAdditionalServiceForm";
            this.Load += new System.EventHandler(this.AddAdditionalServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPreparationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBufferTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ChkNewProvider;
        private System.Windows.Forms.ComboBox CmbExistingProviders;
        private System.Windows.Forms.TextBox TxtDescriptorName;
        private System.Windows.Forms.TextBox TxtDescriptorDescription;
        private System.Windows.Forms.TextBox TxtValueName;
        private System.Windows.Forms.TextBox TxtProviderName;
        private System.Windows.Forms.TextBox TxtProviderAddress;
        private System.Windows.Forms.TextBox TxtProviderCity;
        private System.Windows.Forms.TextBox TxtProviderDistrict;
        private System.Windows.Forms.TextBox TxtProviderPhoneNumber;
        private System.Windows.Forms.TextBox TxtProviderEmail;
        private System.Windows.Forms.NumericUpDown NudCost;
        private System.Windows.Forms.NumericUpDown NudPreparationTime;
        private System.Windows.Forms.NumericUpDown NudBufferTime;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddService;
        private System.Windows.Forms.ListView LstServices;
    }
}