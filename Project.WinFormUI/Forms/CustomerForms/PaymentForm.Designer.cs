namespace Project.WinFormUI.Forms.CustomerForms
{
    partial class PaymentForm
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
            this.LblTotalCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.BtnPay = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUAR ÖDEMESİ";
            // 
            // LblTotalCost
            // 
            this.LblTotalCost.BackColor = System.Drawing.Color.White;
            this.LblTotalCost.Location = new System.Drawing.Point(25, 84);
            this.LblTotalCost.Name = "LblTotalCost";
            this.LblTotalCost.Size = new System.Drawing.Size(584, 206);
            this.LblTotalCost.TabIndex = 0;
            this.LblTotalCost.Text = "Toplam Tutar:[Tutar]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ödeme Şekli :";
            // 
            // CmbPaymentMethod
            // 
            this.CmbPaymentMethod.FormattingEnabled = true;
            this.CmbPaymentMethod.Location = new System.Drawing.Point(140, 315);
            this.CmbPaymentMethod.Name = "CmbPaymentMethod";
            this.CmbPaymentMethod.Size = new System.Drawing.Size(223, 24);
            this.CmbPaymentMethod.TabIndex = 1;
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(237, 365);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(114, 42);
            this.BtnPay.TabIndex = 2;
            this.BtnPay.Text = "Öde";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(101, 365);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(104, 42);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 449);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.CmbPaymentMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTotalCost);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbPaymentMethod;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Button BtnCancel;
    }
}