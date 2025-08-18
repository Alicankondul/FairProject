namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class UpdateDeleteLocationForm
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
            this.LblSelectedLocation = new System.Windows.Forms.Label();
            this.LstLocations = new System.Windows.Forms.ListBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtDistrict = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDeleteLocation = new System.Windows.Forms.Button();
            this.BtnUpdateLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOKASYON BİLGİLERİNİ GÜNCELLE VE SİL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "İl :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "İlçe :";
            // 
            // LblSelectedLocation
            // 
            this.LblSelectedLocation.BackColor = System.Drawing.Color.White;
            this.LblSelectedLocation.Location = new System.Drawing.Point(490, 214);
            this.LblSelectedLocation.Name = "LblSelectedLocation";
            this.LblSelectedLocation.Size = new System.Drawing.Size(400, 183);
            this.LblSelectedLocation.TabIndex = 0;
            // 
            // LstLocations
            // 
            this.LstLocations.FormattingEnabled = true;
            this.LstLocations.ItemHeight = 16;
            this.LstLocations.Location = new System.Drawing.Point(12, 89);
            this.LstLocations.Name = "LstLocations";
            this.LstLocations.Size = new System.Drawing.Size(469, 308);
            this.LstLocations.TabIndex = 1;
            this.LstLocations.SelectedIndexChanged += new System.EventHandler(this.LstLocations_SelectedIndexChanged);
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(548, 89);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(342, 22);
            this.TxtCity.TabIndex = 2;
            // 
            // TxtDistrict
            // 
            this.TxtDistrict.Location = new System.Drawing.Point(548, 125);
            this.TxtDistrict.Name = "TxtDistrict";
            this.TxtDistrict.Size = new System.Drawing.Size(342, 22);
            this.TxtDistrict.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(548, 164);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(103, 24);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "İptal";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDeleteLocation
            // 
            this.BtnDeleteLocation.Location = new System.Drawing.Point(666, 164);
            this.BtnDeleteLocation.Name = "BtnDeleteLocation";
            this.BtnDeleteLocation.Size = new System.Drawing.Size(103, 24);
            this.BtnDeleteLocation.TabIndex = 3;
            this.BtnDeleteLocation.Text = "Sil";
            this.BtnDeleteLocation.UseVisualStyleBackColor = true;
            this.BtnDeleteLocation.Click += new System.EventHandler(this.BtnDeleteLocation_Click);
            // 
            // BtnUpdateLocation
            // 
            this.BtnUpdateLocation.Location = new System.Drawing.Point(787, 164);
            this.BtnUpdateLocation.Name = "BtnUpdateLocation";
            this.BtnUpdateLocation.Size = new System.Drawing.Size(103, 24);
            this.BtnUpdateLocation.TabIndex = 3;
            this.BtnUpdateLocation.Text = "Güncelle";
            this.BtnUpdateLocation.UseVisualStyleBackColor = true;
            this.BtnUpdateLocation.Click += new System.EventHandler(this.BtnUpdateLocation_Click);
            // 
            // UpdateDeleteLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 427);
            this.Controls.Add(this.BtnUpdateLocation);
            this.Controls.Add(this.BtnDeleteLocation);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtDistrict);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.LstLocations);
            this.Controls.Add(this.LblSelectedLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteLocationForm";
            this.Text = "UpdateDeleteLocationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSelectedLocation;
        private System.Windows.Forms.ListBox LstLocations;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtDistrict;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDeleteLocation;
        private System.Windows.Forms.Button BtnUpdateLocation;
    }
}