namespace Project.WinFormUI.Forms.CustomerForms
{
    partial class CustomBuildingRequestForm
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
            this.LblFairDetails = new System.Windows.Forms.Label();
            this.LblBuildingDetails = new System.Windows.Forms.Label();
            this.NUDNumberOfFloor = new System.Windows.Forms.NumericUpDown();
            this.NUDFloorSize = new System.Windows.Forms.NumericUpDown();
            this.NUDRoomPerFloor = new System.Windows.Forms.NumericUpDown();
            this.CmbLocations = new System.Windows.Forms.ComboBox();
            this.LstAvailableBuildings = new System.Windows.Forms.ListBox();
            this.BtnConfirmSelection = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSearchBuildings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFloorSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRoomPerFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖZEL BİNA TALEBİ OLUŞTUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kat Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "MetreKare :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oda Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lokasyon :";
            // 
            // LblFairDetails
            // 
            this.LblFairDetails.BackColor = System.Drawing.Color.White;
            this.LblFairDetails.Location = new System.Drawing.Point(14, 71);
            this.LblFairDetails.Name = "LblFairDetails";
            this.LblFairDetails.Size = new System.Drawing.Size(370, 68);
            this.LblFairDetails.TabIndex = 0;
            // 
            // LblBuildingDetails
            // 
            this.LblBuildingDetails.BackColor = System.Drawing.Color.White;
            this.LblBuildingDetails.Location = new System.Drawing.Point(408, 323);
            this.LblBuildingDetails.Name = "LblBuildingDetails";
            this.LblBuildingDetails.Size = new System.Drawing.Size(412, 133);
            this.LblBuildingDetails.TabIndex = 0;
            // 
            // NUDNumberOfFloor
            // 
            this.NUDNumberOfFloor.Location = new System.Drawing.Point(106, 165);
            this.NUDNumberOfFloor.Name = "NUDNumberOfFloor";
            this.NUDNumberOfFloor.Size = new System.Drawing.Size(168, 22);
            this.NUDNumberOfFloor.TabIndex = 1;
            // 
            // NUDFloorSize
            // 
            this.NUDFloorSize.Location = new System.Drawing.Point(106, 198);
            this.NUDFloorSize.Name = "NUDFloorSize";
            this.NUDFloorSize.Size = new System.Drawing.Size(168, 22);
            this.NUDFloorSize.TabIndex = 1;
            // 
            // NUDRoomPerFloor
            // 
            this.NUDRoomPerFloor.Location = new System.Drawing.Point(106, 232);
            this.NUDRoomPerFloor.Name = "NUDRoomPerFloor";
            this.NUDRoomPerFloor.Size = new System.Drawing.Size(168, 22);
            this.NUDRoomPerFloor.TabIndex = 1;
            // 
            // CmbLocations
            // 
            this.CmbLocations.FormattingEnabled = true;
            this.CmbLocations.Location = new System.Drawing.Point(106, 272);
            this.CmbLocations.Name = "CmbLocations";
            this.CmbLocations.Size = new System.Drawing.Size(168, 24);
            this.CmbLocations.TabIndex = 16;
            this.CmbLocations.SelectedIndexChanged += new System.EventHandler(this.CmbLocations_SelectedIndexChanged);
            // 
            // LstAvailableBuildings
            // 
            this.LstAvailableBuildings.FormattingEnabled = true;
            this.LstAvailableBuildings.ItemHeight = 16;
            this.LstAvailableBuildings.Location = new System.Drawing.Point(411, 71);
            this.LstAvailableBuildings.Name = "LstAvailableBuildings";
            this.LstAvailableBuildings.Size = new System.Drawing.Size(548, 228);
            this.LstAvailableBuildings.TabIndex = 2;
            this.LstAvailableBuildings.SelectedIndexChanged += new System.EventHandler(this.LstAvailableBuildings_SelectedIndexChanged);
            // 
            // BtnConfirmSelection
            // 
            this.BtnConfirmSelection.Location = new System.Drawing.Point(837, 370);
            this.BtnConfirmSelection.Name = "BtnConfirmSelection";
            this.BtnConfirmSelection.Size = new System.Drawing.Size(122, 39);
            this.BtnConfirmSelection.TabIndex = 17;
            this.BtnConfirmSelection.Text = "Seçimi Onayla";
            this.BtnConfirmSelection.UseVisualStyleBackColor = true;
            this.BtnConfirmSelection.Click += new System.EventHandler(this.BtnConfirmSelection_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(17, 357);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(89, 36);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSearchBuildings
            // 
            this.BtnSearchBuildings.Location = new System.Drawing.Point(158, 357);
            this.BtnSearchBuildings.Name = "BtnSearchBuildings";
            this.BtnSearchBuildings.Size = new System.Drawing.Size(91, 36);
            this.BtnSearchBuildings.TabIndex = 17;
            this.BtnSearchBuildings.Text = "Gönder";
            this.BtnSearchBuildings.UseVisualStyleBackColor = true;
            this.BtnSearchBuildings.Click += new System.EventHandler(this.BtnSearchBuildings_Click);
            // 
            // CustomBuildingRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 477);
            this.Controls.Add(this.BtnSearchBuildings);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirmSelection);
            this.Controls.Add(this.LstAvailableBuildings);
            this.Controls.Add(this.CmbLocations);
            this.Controls.Add(this.NUDRoomPerFloor);
            this.Controls.Add(this.NUDFloorSize);
            this.Controls.Add(this.NUDNumberOfFloor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblBuildingDetails);
            this.Controls.Add(this.LblFairDetails);
            this.Controls.Add(this.label1);
            this.Name = "CustomBuildingRequestForm";
            this.Text = "ÖZEL BİNA TALEBİ OLUŞTUR";
            this.Load += new System.EventHandler(this.CustomBuildingRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFloorSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRoomPerFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblFairDetails;
        private System.Windows.Forms.Label LblBuildingDetails;
        private System.Windows.Forms.NumericUpDown NUDNumberOfFloor;
        private System.Windows.Forms.NumericUpDown NUDFloorSize;
        private System.Windows.Forms.NumericUpDown NUDRoomPerFloor;
        private System.Windows.Forms.ComboBox CmbLocations;
        private System.Windows.Forms.ListBox LstAvailableBuildings;
        private System.Windows.Forms.Button BtnConfirmSelection;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSearchBuildings;
    }
}