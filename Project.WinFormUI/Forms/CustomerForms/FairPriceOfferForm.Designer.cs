namespace Project.WinFormUI.Forms.CustomerForms
{
    partial class FairPriceOfferForm
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
            this.LblPriceOfferDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNewOffer = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDeclineOffer = new System.Windows.Forms.Button();
            this.BtnCancelNewOffer = new System.Windows.Forms.Button();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.BtnAcceptOffer = new System.Windows.Forms.Button();
            this.TxtCustomerOffer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUAR OLUŞTUR";
            // 
            // LblPriceOfferDetails
            // 
            this.LblPriceOfferDetails.BackColor = System.Drawing.Color.White;
            this.LblPriceOfferDetails.Location = new System.Drawing.Point(33, 47);
            this.LblPriceOfferDetails.Name = "LblPriceOfferDetails";
            this.LblPriceOfferDetails.Size = new System.Drawing.Size(580, 115);
            this.LblPriceOfferDetails.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Talep Edilen Fiyat :";
            // 
            // LblNewOffer
            // 
            this.LblNewOffer.BackColor = System.Drawing.Color.White;
            this.LblNewOffer.Location = new System.Drawing.Point(33, 301);
            this.LblNewOffer.Name = "LblNewOffer";
            this.LblNewOffer.Size = new System.Drawing.Size(580, 96);
            this.LblNewOffer.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(144, 182);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(119, 27);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDeclineOffer
            // 
            this.BtnDeclineOffer.Location = new System.Drawing.Point(280, 182);
            this.BtnDeclineOffer.Name = "BtnDeclineOffer";
            this.BtnDeclineOffer.Size = new System.Drawing.Size(113, 27);
            this.BtnDeclineOffer.TabIndex = 1;
            this.BtnDeclineOffer.Text = "Onaylama";
            this.BtnDeclineOffer.UseVisualStyleBackColor = true;
            this.BtnDeclineOffer.Click += new System.EventHandler(this.BtnDeclineOffer_Click);
            // 
            // BtnCancelNewOffer
            // 
            this.BtnCancelNewOffer.Location = new System.Drawing.Point(426, 261);
            this.BtnCancelNewOffer.Name = "BtnCancelNewOffer";
            this.BtnCancelNewOffer.Size = new System.Drawing.Size(107, 23);
            this.BtnCancelNewOffer.TabIndex = 1;
            this.BtnCancelNewOffer.Text = "İptal Et";
            this.BtnCancelNewOffer.UseVisualStyleBackColor = true;
            this.BtnCancelNewOffer.Click += new System.EventHandler(this.BtnCancelNewOffer_Click);
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(306, 261);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(114, 23);
            this.BtnGonder.TabIndex = 1;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // BtnAcceptOffer
            // 
            this.BtnAcceptOffer.Location = new System.Drawing.Point(409, 182);
            this.BtnAcceptOffer.Name = "BtnAcceptOffer";
            this.BtnAcceptOffer.Size = new System.Drawing.Size(108, 27);
            this.BtnAcceptOffer.TabIndex = 1;
            this.BtnAcceptOffer.Text = "Onayla";
            this.BtnAcceptOffer.UseVisualStyleBackColor = true;
            this.BtnAcceptOffer.Click += new System.EventHandler(this.BtnAcceptOffer_Click);
            // 
            // TxtCustomerOffer
            // 
            this.TxtCustomerOffer.Location = new System.Drawing.Point(163, 261);
            this.TxtCustomerOffer.Name = "TxtCustomerOffer";
            this.TxtCustomerOffer.Size = new System.Drawing.Size(137, 22);
            this.TxtCustomerOffer.TabIndex = 2;
            // 
            // FairPriceOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 406);
            this.Controls.Add(this.TxtCustomerOffer);
            this.Controls.Add(this.BtnAcceptOffer);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.BtnCancelNewOffer);
            this.Controls.Add(this.BtnDeclineOffer);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblNewOffer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPriceOfferDetails);
            this.Controls.Add(this.label1);
            this.Name = "FairPriceOfferForm";
            this.Text = "FairPriceOfferForm";
            this.Load += new System.EventHandler(this.FairPriceOfferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPriceOfferDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNewOffer;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDeclineOffer;
        private System.Windows.Forms.Button BtnCancelNewOffer;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Button BtnAcceptOffer;
        private System.Windows.Forms.TextBox TxtCustomerOffer;
    }
}