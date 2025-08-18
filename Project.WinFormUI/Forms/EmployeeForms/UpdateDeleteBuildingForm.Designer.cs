namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class UpdateDeleteBuildingForm
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
            this.LblSelectedBuilding = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LstBuildings = new System.Windows.Forms.ListBox();
            this.TxtBuildingName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.NudNumberOfFloor = new System.Windows.Forms.NumericUpDown();
            this.NudFloorSize = new System.Windows.Forms.NumericUpDown();
            this.NudRoomPerFloor = new System.Windows.Forms.NumericUpDown();
            this.CmbLocation = new System.Windows.Forms.ComboBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDeleteBuilding = new System.Windows.Forms.Button();
            this.BtnUpdateBuilding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumberOfFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFloorSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRoomPerFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(259, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "BİNA BİLGİLERİNİ GÜNCELLE VE SİL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bina İsmi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bina Adresi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kat Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Metrekare :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oda Sayısı :";
            // 
            // LblSelectedBuilding
            // 
            this.LblSelectedBuilding.BackColor = System.Drawing.Color.White;
            this.LblSelectedBuilding.Location = new System.Drawing.Point(513, 362);
            this.LblSelectedBuilding.Name = "LblSelectedBuilding";
            this.LblSelectedBuilding.Size = new System.Drawing.Size(504, 183);
            this.LblSelectedBuilding.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lokasyon :";
            // 
            // LstBuildings
            // 
            this.LstBuildings.FormattingEnabled = true;
            this.LstBuildings.ItemHeight = 16;
            this.LstBuildings.Location = new System.Drawing.Point(12, 110);
            this.LstBuildings.Name = "LstBuildings";
            this.LstBuildings.Size = new System.Drawing.Size(481, 436);
            this.LstBuildings.TabIndex = 1;
            this.LstBuildings.SelectedIndexChanged += new System.EventHandler(this.LstBuildings_SelectedIndexChanged);
            // 
            // TxtBuildingName
            // 
            this.TxtBuildingName.Location = new System.Drawing.Point(612, 110);
            this.TxtBuildingName.Name = "TxtBuildingName";
            this.TxtBuildingName.Size = new System.Drawing.Size(405, 22);
            this.TxtBuildingName.TabIndex = 2;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(612, 140);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(405, 22);
            this.TxtAddress.TabIndex = 2;
            // 
            // NudNumberOfFloor
            // 
            this.NudNumberOfFloor.Location = new System.Drawing.Point(612, 171);
            this.NudNumberOfFloor.Name = "NudNumberOfFloor";
            this.NudNumberOfFloor.Size = new System.Drawing.Size(405, 22);
            this.NudNumberOfFloor.TabIndex = 3;
            // 
            // NudFloorSize
            // 
            this.NudFloorSize.Location = new System.Drawing.Point(612, 198);
            this.NudFloorSize.Name = "NudFloorSize";
            this.NudFloorSize.Size = new System.Drawing.Size(405, 22);
            this.NudFloorSize.TabIndex = 3;
            // 
            // NudRoomPerFloor
            // 
            this.NudRoomPerFloor.Location = new System.Drawing.Point(612, 232);
            this.NudRoomPerFloor.Name = "NudRoomPerFloor";
            this.NudRoomPerFloor.Size = new System.Drawing.Size(405, 22);
            this.NudRoomPerFloor.TabIndex = 3;
            // 
            // CmbLocation
            // 
            this.CmbLocation.FormattingEnabled = true;
            this.CmbLocation.Location = new System.Drawing.Point(612, 263);
            this.CmbLocation.Name = "CmbLocation";
            this.CmbLocation.Size = new System.Drawing.Size(405, 24);
            this.CmbLocation.TabIndex = 4;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(520, 312);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 34);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "İptal";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDeleteBuilding
            // 
            this.BtnDeleteBuilding.Location = new System.Drawing.Point(624, 312);
            this.BtnDeleteBuilding.Name = "BtnDeleteBuilding";
            this.BtnDeleteBuilding.Size = new System.Drawing.Size(100, 34);
            this.BtnDeleteBuilding.TabIndex = 5;
            this.BtnDeleteBuilding.Text = "Sil";
            this.BtnDeleteBuilding.UseVisualStyleBackColor = true;
            this.BtnDeleteBuilding.Click += new System.EventHandler(this.BtnDeleteBuilding_Click);
            // 
            // BtnUpdateBuilding
            // 
            this.BtnUpdateBuilding.Location = new System.Drawing.Point(730, 312);
            this.BtnUpdateBuilding.Name = "BtnUpdateBuilding";
            this.BtnUpdateBuilding.Size = new System.Drawing.Size(95, 34);
            this.BtnUpdateBuilding.TabIndex = 5;
            this.BtnUpdateBuilding.Text = "Güncelle";
            this.BtnUpdateBuilding.UseVisualStyleBackColor = true;
            this.BtnUpdateBuilding.Click += new System.EventHandler(this.BtnUpdateBuilding_Click);
            // 
            // UpdateDeleteBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 554);
            this.Controls.Add(this.BtnUpdateBuilding);
            this.Controls.Add(this.BtnDeleteBuilding);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CmbLocation);
            this.Controls.Add(this.NudRoomPerFloor);
            this.Controls.Add(this.NudFloorSize);
            this.Controls.Add(this.NudNumberOfFloor);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtBuildingName);
            this.Controls.Add(this.LstBuildings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblSelectedBuilding);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteBuildingForm";
            this.Text = "Bina Güncelle / Sil";
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
        private System.Windows.Forms.Label LblSelectedBuilding;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LstBuildings;
        private System.Windows.Forms.TextBox TxtBuildingName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.NumericUpDown NudNumberOfFloor;
        private System.Windows.Forms.NumericUpDown NudFloorSize;
        private System.Windows.Forms.NumericUpDown NudRoomPerFloor;
        private System.Windows.Forms.ComboBox CmbLocation;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDeleteBuilding;
        private System.Windows.Forms.Button BtnUpdateBuilding;
    }
}