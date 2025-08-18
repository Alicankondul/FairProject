namespace Project.WinFormUI.Forms.LoginForms
{
    partial class Login
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
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.ChkShowPassword = new System.Windows.Forms.CheckBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnForgotPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOUBLE_H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fuar Yönetim Sistemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hesabınıza Giriş Yapın";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre :";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(111, 206);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(250, 22);
            this.TxtEmail.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(111, 254);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(250, 22);
            this.TxtPassword.TabIndex = 1;
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChkShowPassword.Location = new System.Drawing.Point(101, 318);
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Size = new System.Drawing.Size(115, 20);
            this.ChkShowPassword.TabIndex = 2;
            this.ChkShowPassword.Text = "Şifreyi Göster";
            this.ChkShowPassword.UseVisualStyleBackColor = true;
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(252, 307);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(109, 34);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(101, 364);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(109, 34);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Kayıt Ol";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnForgotPassword
            // 
            this.BtnForgotPassword.Location = new System.Drawing.Point(252, 364);
            this.BtnForgotPassword.Name = "BtnForgotPassword";
            this.BtnForgotPassword.Size = new System.Drawing.Size(109, 34);
            this.BtnForgotPassword.TabIndex = 3;
            this.BtnForgotPassword.Text = "Şifreyi Unuttum";
            this.BtnForgotPassword.UseVisualStyleBackColor = true;
            this.BtnForgotPassword.Click += new System.EventHandler(this.BtnForgotPassword_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 447);
            this.Controls.Add(this.BtnForgotPassword);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.ChkShowPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox ChkShowPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnForgotPassword;
    }
}