namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class AddLocationForm
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
            this.TxtDistrict = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddLocation = new System.Windows.Forms.Button();
            this.LstLocations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOKASYON EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "İlçe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "İl :";
            // 
            // TxtDistrict
            // 
            this.TxtDistrict.Location = new System.Drawing.Point(102, 80);
            this.TxtDistrict.Name = "TxtDistrict";
            this.TxtDistrict.Size = new System.Drawing.Size(246, 22);
            this.TxtDistrict.TabIndex = 1;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(102, 124);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(246, 22);
            this.TxtCity.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(37, 205);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(132, 32);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "İptal";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddLocation
            // 
            this.BtnAddLocation.Location = new System.Drawing.Point(205, 205);
            this.BtnAddLocation.Name = "BtnAddLocation";
            this.BtnAddLocation.Size = new System.Drawing.Size(143, 32);
            this.BtnAddLocation.TabIndex = 2;
            this.BtnAddLocation.Text = "Lokasyon Ekle";
            this.BtnAddLocation.UseVisualStyleBackColor = true;
            this.BtnAddLocation.Click += new System.EventHandler(this.BtnAddLocation_Click);
            // 
            // LstLocations
            // 
            this.LstLocations.FormattingEnabled = true;
            this.LstLocations.ItemHeight = 16;
            this.LstLocations.Location = new System.Drawing.Point(394, 80);
            this.LstLocations.Name = "LstLocations";
            this.LstLocations.Size = new System.Drawing.Size(394, 340);
            this.LstLocations.TabIndex = 3;
            // 
            // AddLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstLocations);
            this.Controls.Add(this.BtnAddLocation);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtDistrict);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddLocationForm";
            this.Text = "Lokasyon Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDistrict;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddLocation;
        private System.Windows.Forms.ListBox LstLocations;
    }
}