namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class AddEmployeeForm
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
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtDistrict = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.CmbRole = new System.Windows.Forms.ComboBox();
            this.CmbManager = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.LstCurrentEmployees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇALIŞAN EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(174, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kişisel Bilgiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(441, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mevcut Çalışanlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "TC :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon Numarası :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Şifre :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şifre Tekrarı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Adres :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "İl :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 565);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Çalışan Rolü :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 603);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Çalışan Yöneticisi :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(174, 523);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Çalışan Rolü ve Yönetici";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(174, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "İletişim Bilgileri";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(103, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "E-Mail :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(120, 449);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "İlçe :";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(178, 110);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(183, 22);
            this.TxtFirstName.TabIndex = 1;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(178, 143);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(183, 22);
            this.TxtLastName.TabIndex = 1;
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(178, 183);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(183, 22);
            this.TxtTC.TabIndex = 1;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(178, 224);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(183, 22);
            this.TxtPhoneNumber.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(178, 311);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(183, 22);
            this.TxtEmail.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(178, 344);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(183, 22);
            this.TxtPassword.TabIndex = 1;
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(178, 381);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(183, 22);
            this.TxtConfirmPassword.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(178, 413);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(183, 22);
            this.TxtAddress.TabIndex = 1;
            // 
            // TxtDistrict
            // 
            this.TxtDistrict.Location = new System.Drawing.Point(178, 446);
            this.TxtDistrict.Name = "TxtDistrict";
            this.TxtDistrict.Size = new System.Drawing.Size(183, 22);
            this.TxtDistrict.TabIndex = 1;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(178, 487);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(183, 22);
            this.TxtCity.TabIndex = 1;
            // 
            // CmbRole
            // 
            this.CmbRole.FormattingEnabled = true;
            this.CmbRole.Location = new System.Drawing.Point(178, 562);
            this.CmbRole.Name = "CmbRole";
            this.CmbRole.Size = new System.Drawing.Size(183, 24);
            this.CmbRole.TabIndex = 2;
            // 
            // CmbManager
            // 
            this.CmbManager.FormattingEnabled = true;
            this.CmbManager.Location = new System.Drawing.Point(178, 600);
            this.CmbManager.Name = "CmbManager";
            this.CmbManager.Size = new System.Drawing.Size(183, 24);
            this.CmbManager.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(126, 657);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(101, 31);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(251, 657);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(101, 31);
            this.BtnAddEmployee.TabIndex = 3;
            this.BtnAddEmployee.Text = "Çalışan Ekle";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // LstCurrentEmployees
            // 
            this.LstCurrentEmployees.FormattingEnabled = true;
            this.LstCurrentEmployees.ItemHeight = 16;
            this.LstCurrentEmployees.Location = new System.Drawing.Point(445, 110);
            this.LstCurrentEmployees.Name = "LstCurrentEmployees";
            this.LstCurrentEmployees.Size = new System.Drawing.Size(577, 580);
            this.LstCurrentEmployees.TabIndex = 4;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 804);
            this.Controls.Add(this.LstCurrentEmployees);
            this.Controls.Add(this.BtnAddEmployee);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.CmbManager);
            this.Controls.Add(this.CmbRole);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtDistrict);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeeForm";
            this.Text = "Çalışan Ekle";
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtDistrict;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.ComboBox CmbRole;
        private System.Windows.Forms.ComboBox CmbManager;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.ListBox LstCurrentEmployees;
    }
}