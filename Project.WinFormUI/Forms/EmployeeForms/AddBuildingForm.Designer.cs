namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class AddBuildingForm
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
            this.TxtBuildingName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.NudNumberOfFloor = new System.Windows.Forms.NumericUpDown();
            this.NudFloorSize = new System.Windows.Forms.NumericUpDown();
            this.NudRoomPerFloor = new System.Windows.Forms.NumericUpDown();
            this.CmbLocation = new System.Windows.Forms.ComboBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddBuilding = new System.Windows.Forms.Button();
            this.LstBuildings = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumberOfFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFloorSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRoomPerFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "BİNA EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bina İsmi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bina Adresi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kat Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Metrekare :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oda Sayısı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Konum :";
            // 
            // TxtBuildingName
            // 
            this.TxtBuildingName.Location = new System.Drawing.Point(134, 95);
            this.TxtBuildingName.Name = "TxtBuildingName";
            this.TxtBuildingName.Size = new System.Drawing.Size(287, 22);
            this.TxtBuildingName.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(134, 132);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(287, 22);
            this.TxtAddress.TabIndex = 1;
            // 
            // NudNumberOfFloor
            // 
            this.NudNumberOfFloor.Location = new System.Drawing.Point(134, 166);
            this.NudNumberOfFloor.Name = "NudNumberOfFloor";
            this.NudNumberOfFloor.Size = new System.Drawing.Size(159, 22);
            this.NudNumberOfFloor.TabIndex = 2;
            // 
            // NudFloorSize
            // 
            this.NudFloorSize.Location = new System.Drawing.Point(134, 204);
            this.NudFloorSize.Name = "NudFloorSize";
            this.NudFloorSize.Size = new System.Drawing.Size(159, 22);
            this.NudFloorSize.TabIndex = 2;
            // 
            // NudRoomPerFloor
            // 
            this.NudRoomPerFloor.Location = new System.Drawing.Point(134, 241);
            this.NudRoomPerFloor.Name = "NudRoomPerFloor";
            this.NudRoomPerFloor.Size = new System.Drawing.Size(159, 22);
            this.NudRoomPerFloor.TabIndex = 2;
            // 
            // CmbLocation
            // 
            this.CmbLocation.FormattingEnabled = true;
            this.CmbLocation.Location = new System.Drawing.Point(134, 279);
            this.CmbLocation.Name = "CmbLocation";
            this.CmbLocation.Size = new System.Drawing.Size(159, 24);
            this.CmbLocation.TabIndex = 3;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(204, 326);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(89, 36);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "İptal";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddBuilding
            // 
            this.BtnAddBuilding.Location = new System.Drawing.Point(332, 326);
            this.BtnAddBuilding.Name = "BtnAddBuilding";
            this.BtnAddBuilding.Size = new System.Drawing.Size(89, 36);
            this.BtnAddBuilding.TabIndex = 4;
            this.BtnAddBuilding.Text = "Bina Ekle";
            this.BtnAddBuilding.UseVisualStyleBackColor = true;
            this.BtnAddBuilding.Click += new System.EventHandler(this.BtnAddBuilding_Click);
            // 
            // LstBuildings
            // 
            this.LstBuildings.FormattingEnabled = true;
            this.LstBuildings.ItemHeight = 16;
            this.LstBuildings.Location = new System.Drawing.Point(469, 98);
            this.LstBuildings.Name = "LstBuildings";
            this.LstBuildings.Size = new System.Drawing.Size(561, 276);
            this.LstBuildings.TabIndex = 5;
            // 
            // AddBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 398);
            this.Controls.Add(this.LstBuildings);
            this.Controls.Add(this.BtnAddBuilding);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CmbLocation);
            this.Controls.Add(this.NudRoomPerFloor);
            this.Controls.Add(this.NudFloorSize);
            this.Controls.Add(this.NudNumberOfFloor);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtBuildingName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBuildingForm";
            this.Text = "Bina Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.NudNumberOfFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFloorSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRoomPerFloor)).EndInit();
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
        private System.Windows.Forms.TextBox TxtBuildingName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.NumericUpDown NudNumberOfFloor;
        private System.Windows.Forms.NumericUpDown NudFloorSize;
        private System.Windows.Forms.NumericUpDown NudRoomPerFloor;
        private System.Windows.Forms.ComboBox CmbLocation;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddBuilding;
        private System.Windows.Forms.ListBox LstBuildings;
    }
}