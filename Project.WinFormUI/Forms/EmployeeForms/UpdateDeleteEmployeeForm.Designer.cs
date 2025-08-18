namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class UpdateDeleteEmployeeForm
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
            this.LblSelectedEmployee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LstEmployees = new System.Windows.Forms.ListBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtDistrict = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.BtnUpdateEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇALIŞAN BİLGİLERİNİ GÜNCELLE VE SİL";
            // 
            // LblSelectedEmployee
            // 
            this.LblSelectedEmployee.BackColor = System.Drawing.Color.White;
            this.LblSelectedEmployee.Location = new System.Drawing.Point(15, 221);
            this.LblSelectedEmployee.Name = "LblSelectedEmployee";
            this.LblSelectedEmployee.Size = new System.Drawing.Size(483, 166);
            this.LblSelectedEmployee.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyisim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "TC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "E-Mail :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adres :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(590, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "İsim :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "İl :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(590, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "İlçe :";
            // 
            // LstEmployees
            // 
            this.LstEmployees.FormattingEnabled = true;
            this.LstEmployees.ItemHeight = 16;
            this.LstEmployees.Location = new System.Drawing.Point(18, 63);
            this.LstEmployees.Name = "LstEmployees";
            this.LstEmployees.Size = new System.Drawing.Size(481, 148);
            this.LstEmployees.TabIndex = 1;
            this.LstEmployees.SelectedIndexChanged += new System.EventHandler(this.LstEmployees_SelectedIndexChanged);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(633, 63);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(421, 22);
            this.TxtFirstName.TabIndex = 2;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(633, 92);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(421, 22);
            this.TxtLastName.TabIndex = 2;
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(634, 122);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(421, 22);
            this.TxtTC.TabIndex = 2;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(634, 154);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(421, 22);
            this.TxtPhoneNumber.TabIndex = 2;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(634, 183);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(421, 22);
            this.TxtEmail.TabIndex = 2;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(634, 218);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(421, 22);
            this.TxtAddress.TabIndex = 2;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(634, 255);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(421, 22);
            this.TxtCity.TabIndex = 2;
            // 
            // TxtDistrict
            // 
            this.TxtDistrict.Location = new System.Drawing.Point(634, 286);
            this.TxtDistrict.Name = "TxtDistrict";
            this.TxtDistrict.Size = new System.Drawing.Size(421, 22);
            this.TxtDistrict.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(706, 333);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(90, 32);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "İptal";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(802, 333);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(90, 32);
            this.BtnDeleteEmployee.TabIndex = 3;
            this.BtnDeleteEmployee.Text = "Sil";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // BtnUpdateEmployee
            // 
            this.BtnUpdateEmployee.Location = new System.Drawing.Point(898, 333);
            this.BtnUpdateEmployee.Name = "BtnUpdateEmployee";
            this.BtnUpdateEmployee.Size = new System.Drawing.Size(90, 32);
            this.BtnUpdateEmployee.TabIndex = 3;
            this.BtnUpdateEmployee.Text = "Güncelle";
            this.BtnUpdateEmployee.UseVisualStyleBackColor = true;
            this.BtnUpdateEmployee.Click += new System.EventHandler(this.BtnUpdateEmployee_Click);
            // 
            // UpdateDeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 417);
            this.Controls.Add(this.BtnUpdateEmployee);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtDistrict);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LstEmployees);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblSelectedEmployee);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteEmployeeForm";
            this.Text = "Çalışan Güncelle / Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSelectedEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox LstEmployees;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtDistrict;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDeleteEmployee;
        private System.Windows.Forms.Button BtnUpdateEmployee;
    }
}