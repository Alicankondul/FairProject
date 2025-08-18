namespace Project.WinFormUI.Forms.EmployeeForms
{
    partial class EmployeeDashboard
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
            this.TbcEmployeeDashboard = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAddService = new System.Windows.Forms.Button();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.BtnAddLocation = new System.Windows.Forms.Button();
            this.BtnAddBuilding = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnExitUpdate = new System.Windows.Forms.Button();
            this.BtnUpdateService = new System.Windows.Forms.Button();
            this.BtnUpdateEmployee = new System.Windows.Forms.Button();
            this.BtnUpdateLocation = new System.Windows.Forms.Button();
            this.BtnUpdateBuilding = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FlpReportButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnEmployeeReport = new System.Windows.Forms.Button();
            this.BtnServiceReport = new System.Windows.Forms.Button();
            this.BtnBuildingReport = new System.Windows.Forms.Button();
            this.BtnLocationReport = new System.Windows.Forms.Button();
            this.BtnMevcutFuarlar = new System.Windows.Forms.Button();
            this.BtnFuarOdemeleri = new System.Windows.Forms.Button();
            this.LstReportResults = new System.Windows.Forms.ListBox();
            this.BtnExitReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LstDelayHistory = new System.Windows.Forms.ListBox();
            this.BtnViewDelays = new System.Windows.Forms.Button();
            this.BtnSaveDelay = new System.Windows.Forms.Button();
            this.TxtDelayReason = new System.Windows.Forms.TextBox();
            this.NudDelayDuration = new System.Windows.Forms.NumericUpDown();
            this.LblSelectedFairDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvFairs = new System.Windows.Forms.DataGridView();
            this.TbcEmployeeDashboard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.FlpReportButtons.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDelayDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFairs)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcEmployeeDashboard
            // 
            this.TbcEmployeeDashboard.Controls.Add(this.tabPage1);
            this.TbcEmployeeDashboard.Controls.Add(this.tabPage2);
            this.TbcEmployeeDashboard.Controls.Add(this.tabPage3);
            this.TbcEmployeeDashboard.Controls.Add(this.tabPage4);
            this.TbcEmployeeDashboard.Location = new System.Drawing.Point(12, 23);
            this.TbcEmployeeDashboard.Name = "TbcEmployeeDashboard";
            this.TbcEmployeeDashboard.SelectedIndex = 0;
            this.TbcEmployeeDashboard.Size = new System.Drawing.Size(1223, 697);
            this.TbcEmployeeDashboard.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnExit);
            this.tabPage1.Controls.Add(this.BtnAddService);
            this.tabPage1.Controls.Add(this.BtnAddEmployee);
            this.tabPage1.Controls.Add(this.BtnAddLocation);
            this.tabPage1.Controls.Add(this.BtnAddBuilding);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1215, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(62, 199);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(299, 44);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Çıkış Yap";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAddService
            // 
            this.BtnAddService.Location = new System.Drawing.Point(219, 133);
            this.BtnAddService.Name = "BtnAddService";
            this.BtnAddService.Size = new System.Drawing.Size(142, 44);
            this.BtnAddService.TabIndex = 0;
            this.BtnAddService.Text = "Hizmet Ekle";
            this.BtnAddService.UseVisualStyleBackColor = true;
            this.BtnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(62, 133);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(142, 44);
            this.BtnAddEmployee.TabIndex = 0;
            this.BtnAddEmployee.Text = "Çalışan Ekle";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // BtnAddLocation
            // 
            this.BtnAddLocation.Location = new System.Drawing.Point(219, 72);
            this.BtnAddLocation.Name = "BtnAddLocation";
            this.BtnAddLocation.Size = new System.Drawing.Size(142, 44);
            this.BtnAddLocation.TabIndex = 0;
            this.BtnAddLocation.Text = "Lokasyon Ekle";
            this.BtnAddLocation.UseVisualStyleBackColor = true;
            this.BtnAddLocation.Click += new System.EventHandler(this.BtnAddLocation_Click);
            // 
            // BtnAddBuilding
            // 
            this.BtnAddBuilding.Location = new System.Drawing.Point(62, 72);
            this.BtnAddBuilding.Name = "BtnAddBuilding";
            this.BtnAddBuilding.Size = new System.Drawing.Size(142, 44);
            this.BtnAddBuilding.TabIndex = 0;
            this.BtnAddBuilding.Text = "Bina Ekle";
            this.BtnAddBuilding.UseVisualStyleBackColor = true;
            this.BtnAddBuilding.Click += new System.EventHandler(this.BtnAddBuilding_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnExitUpdate);
            this.tabPage2.Controls.Add(this.BtnUpdateService);
            this.tabPage2.Controls.Add(this.BtnUpdateEmployee);
            this.tabPage2.Controls.Add(this.BtnUpdateLocation);
            this.tabPage2.Controls.Add(this.BtnUpdateBuilding);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1215, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Güncelle/Sil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnExitUpdate
            // 
            this.BtnExitUpdate.Location = new System.Drawing.Point(59, 195);
            this.BtnExitUpdate.Name = "BtnExitUpdate";
            this.BtnExitUpdate.Size = new System.Drawing.Size(298, 41);
            this.BtnExitUpdate.TabIndex = 0;
            this.BtnExitUpdate.Text = "Çıkış Yap";
            this.BtnExitUpdate.UseVisualStyleBackColor = true;
            this.BtnExitUpdate.Click += new System.EventHandler(this.BtnExitUpdate_Click);
            // 
            // BtnUpdateService
            // 
            this.BtnUpdateService.Location = new System.Drawing.Point(217, 131);
            this.BtnUpdateService.Name = "BtnUpdateService";
            this.BtnUpdateService.Size = new System.Drawing.Size(140, 41);
            this.BtnUpdateService.TabIndex = 0;
            this.BtnUpdateService.Text = "Hizmet Güncelle";
            this.BtnUpdateService.UseVisualStyleBackColor = true;
            this.BtnUpdateService.Click += new System.EventHandler(this.BtnUpdateService_Click);
            // 
            // BtnUpdateEmployee
            // 
            this.BtnUpdateEmployee.Location = new System.Drawing.Point(59, 131);
            this.BtnUpdateEmployee.Name = "BtnUpdateEmployee";
            this.BtnUpdateEmployee.Size = new System.Drawing.Size(140, 41);
            this.BtnUpdateEmployee.TabIndex = 0;
            this.BtnUpdateEmployee.Text = "Çalışan Güncelle";
            this.BtnUpdateEmployee.UseVisualStyleBackColor = true;
            this.BtnUpdateEmployee.Click += new System.EventHandler(this.BtnUpdateEmployee_Click);
            // 
            // BtnUpdateLocation
            // 
            this.BtnUpdateLocation.Location = new System.Drawing.Point(217, 67);
            this.BtnUpdateLocation.Name = "BtnUpdateLocation";
            this.BtnUpdateLocation.Size = new System.Drawing.Size(140, 41);
            this.BtnUpdateLocation.TabIndex = 0;
            this.BtnUpdateLocation.Text = "Lokasyon Güncelle";
            this.BtnUpdateLocation.UseVisualStyleBackColor = true;
            this.BtnUpdateLocation.Click += new System.EventHandler(this.BtnUpdateLocation_Click);
            // 
            // BtnUpdateBuilding
            // 
            this.BtnUpdateBuilding.Location = new System.Drawing.Point(59, 67);
            this.BtnUpdateBuilding.Name = "BtnUpdateBuilding";
            this.BtnUpdateBuilding.Size = new System.Drawing.Size(140, 41);
            this.BtnUpdateBuilding.TabIndex = 0;
            this.BtnUpdateBuilding.Text = "Bina Güncelle";
            this.BtnUpdateBuilding.UseVisualStyleBackColor = true;
            this.BtnUpdateBuilding.Click += new System.EventHandler(this.BtnUpdateBuilding_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FlpReportButtons);
            this.tabPage3.Controls.Add(this.LstReportResults);
            this.tabPage3.Controls.Add(this.BtnExitReport);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1215, 668);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raporlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FlpReportButtons
            // 
            this.FlpReportButtons.Controls.Add(this.BtnEmployeeReport);
            this.FlpReportButtons.Controls.Add(this.BtnServiceReport);
            this.FlpReportButtons.Controls.Add(this.BtnBuildingReport);
            this.FlpReportButtons.Controls.Add(this.BtnLocationReport);
            this.FlpReportButtons.Controls.Add(this.BtnMevcutFuarlar);
            this.FlpReportButtons.Controls.Add(this.BtnFuarOdemeleri);
            this.FlpReportButtons.Location = new System.Drawing.Point(28, 92);
            this.FlpReportButtons.Name = "FlpReportButtons";
            this.FlpReportButtons.Size = new System.Drawing.Size(882, 84);
            this.FlpReportButtons.TabIndex = 3;
            // 
            // BtnEmployeeReport
            // 
            this.BtnEmployeeReport.Location = new System.Drawing.Point(3, 3);
            this.BtnEmployeeReport.Name = "BtnEmployeeReport";
            this.BtnEmployeeReport.Size = new System.Drawing.Size(140, 28);
            this.BtnEmployeeReport.TabIndex = 0;
            this.BtnEmployeeReport.Text = "Çalışan Raporu";
            this.BtnEmployeeReport.UseVisualStyleBackColor = true;
            this.BtnEmployeeReport.Click += new System.EventHandler(this.BtnEmployeeReport_Click);
            // 
            // BtnServiceReport
            // 
            this.BtnServiceReport.Location = new System.Drawing.Point(149, 3);
            this.BtnServiceReport.Name = "BtnServiceReport";
            this.BtnServiceReport.Size = new System.Drawing.Size(140, 28);
            this.BtnServiceReport.TabIndex = 0;
            this.BtnServiceReport.Text = "HizmetRaporu";
            this.BtnServiceReport.UseVisualStyleBackColor = true;
            this.BtnServiceReport.Click += new System.EventHandler(this.BtnServiceReport_Click);
            // 
            // BtnBuildingReport
            // 
            this.BtnBuildingReport.Location = new System.Drawing.Point(295, 3);
            this.BtnBuildingReport.Name = "BtnBuildingReport";
            this.BtnBuildingReport.Size = new System.Drawing.Size(140, 28);
            this.BtnBuildingReport.TabIndex = 0;
            this.BtnBuildingReport.Text = "Bina Raporu";
            this.BtnBuildingReport.UseVisualStyleBackColor = true;
            this.BtnBuildingReport.Click += new System.EventHandler(this.BtnBuildingReport_Click);
            // 
            // BtnLocationReport
            // 
            this.BtnLocationReport.Location = new System.Drawing.Point(441, 3);
            this.BtnLocationReport.Name = "BtnLocationReport";
            this.BtnLocationReport.Size = new System.Drawing.Size(140, 28);
            this.BtnLocationReport.TabIndex = 0;
            this.BtnLocationReport.Text = "Lokasyon Raporu";
            this.BtnLocationReport.UseVisualStyleBackColor = true;
            this.BtnLocationReport.Click += new System.EventHandler(this.BtnLocationReport_Click);
            // 
            // BtnMevcutFuarlar
            // 
            this.BtnMevcutFuarlar.Location = new System.Drawing.Point(587, 3);
            this.BtnMevcutFuarlar.Name = "BtnMevcutFuarlar";
            this.BtnMevcutFuarlar.Size = new System.Drawing.Size(140, 28);
            this.BtnMevcutFuarlar.TabIndex = 0;
            this.BtnMevcutFuarlar.Text = "Mevcut Fuarlar";
            this.BtnMevcutFuarlar.UseVisualStyleBackColor = true;
            this.BtnMevcutFuarlar.Click += new System.EventHandler(this.BtnMevcutFuarlar_Click);
            // 
            // BtnFuarOdemeleri
            // 
            this.BtnFuarOdemeleri.Location = new System.Drawing.Point(733, 3);
            this.BtnFuarOdemeleri.Name = "BtnFuarOdemeleri";
            this.BtnFuarOdemeleri.Size = new System.Drawing.Size(140, 28);
            this.BtnFuarOdemeleri.TabIndex = 0;
            this.BtnFuarOdemeleri.Text = "Fuar Ödemeleri";
            this.BtnFuarOdemeleri.UseVisualStyleBackColor = true;
            this.BtnFuarOdemeleri.Click += new System.EventHandler(this.BtnFuarOdemeleri_Click);
            // 
            // LstReportResults
            // 
            this.LstReportResults.FormattingEnabled = true;
            this.LstReportResults.ItemHeight = 16;
            this.LstReportResults.Location = new System.Drawing.Point(40, 313);
            this.LstReportResults.Name = "LstReportResults";
            this.LstReportResults.Size = new System.Drawing.Size(1121, 308);
            this.LstReportResults.TabIndex = 2;
            this.LstReportResults.DoubleClick += new System.EventHandler(this.LstReportResults_DoubleClick);
            // 
            // BtnExitReport
            // 
            this.BtnExitReport.Location = new System.Drawing.Point(28, 223);
            this.BtnExitReport.Name = "BtnExitReport";
            this.BtnExitReport.Size = new System.Drawing.Size(180, 42);
            this.BtnExitReport.TabIndex = 1;
            this.BtnExitReport.Text = "İptal";
            this.BtnExitReport.UseVisualStyleBackColor = true;
            this.BtnExitReport.Click += new System.EventHandler(this.BtnExitReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAPORLAR";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LstDelayHistory);
            this.tabPage4.Controls.Add(this.BtnViewDelays);
            this.tabPage4.Controls.Add(this.BtnSaveDelay);
            this.tabPage4.Controls.Add(this.TxtDelayReason);
            this.tabPage4.Controls.Add(this.NudDelayDuration);
            this.tabPage4.Controls.Add(this.LblSelectedFairDetails);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.DgvFairs);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1215, 668);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gecikme Yönetimi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LstDelayHistory
            // 
            this.LstDelayHistory.FormattingEnabled = true;
            this.LstDelayHistory.ItemHeight = 16;
            this.LstDelayHistory.Location = new System.Drawing.Point(547, 502);
            this.LstDelayHistory.Name = "LstDelayHistory";
            this.LstDelayHistory.Size = new System.Drawing.Size(627, 148);
            this.LstDelayHistory.TabIndex = 5;
            // 
            // BtnViewDelays
            // 
            this.BtnViewDelays.Location = new System.Drawing.Point(531, 401);
            this.BtnViewDelays.Name = "BtnViewDelays";
            this.BtnViewDelays.Size = new System.Drawing.Size(136, 30);
            this.BtnViewDelays.TabIndex = 4;
            this.BtnViewDelays.Text = "Gecikmeleri Gör";
            this.BtnViewDelays.UseVisualStyleBackColor = true;
            this.BtnViewDelays.Click += new System.EventHandler(this.BtnViewDelays_Click);
            // 
            // BtnSaveDelay
            // 
            this.BtnSaveDelay.Location = new System.Drawing.Point(369, 401);
            this.BtnSaveDelay.Name = "BtnSaveDelay";
            this.BtnSaveDelay.Size = new System.Drawing.Size(137, 30);
            this.BtnSaveDelay.TabIndex = 4;
            this.BtnSaveDelay.Text = "Kaydet";
            this.BtnSaveDelay.UseVisualStyleBackColor = true;
            this.BtnSaveDelay.Click += new System.EventHandler(this.BtnSaveDelay_Click);
            // 
            // TxtDelayReason
            // 
            this.TxtDelayReason.Location = new System.Drawing.Point(150, 453);
            this.TxtDelayReason.Name = "TxtDelayReason";
            this.TxtDelayReason.Size = new System.Drawing.Size(168, 22);
            this.TxtDelayReason.TabIndex = 3;
            // 
            // NudDelayDuration
            // 
            this.NudDelayDuration.Location = new System.Drawing.Point(150, 406);
            this.NudDelayDuration.Name = "NudDelayDuration";
            this.NudDelayDuration.Size = new System.Drawing.Size(168, 22);
            this.NudDelayDuration.TabIndex = 2;
            // 
            // LblSelectedFairDetails
            // 
            this.LblSelectedFairDetails.BackColor = System.Drawing.Color.Gray;
            this.LblSelectedFairDetails.Location = new System.Drawing.Point(6, 502);
            this.LblSelectedFairDetails.Name = "LblSelectedFairDetails";
            this.LblSelectedFairDetails.Size = new System.Drawing.Size(489, 149);
            this.LblSelectedFairDetails.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gecikme Nedeni :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gecikme Süresi :";
            // 
            // DgvFairs
            // 
            this.DgvFairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFairs.Location = new System.Drawing.Point(6, 35);
            this.DgvFairs.Name = "DgvFairs";
            this.DgvFairs.RowHeadersWidth = 51;
            this.DgvFairs.RowTemplate.Height = 24;
            this.DgvFairs.Size = new System.Drawing.Size(1168, 346);
            this.DgvFairs.TabIndex = 0;
            this.DgvFairs.SelectionChanged += new System.EventHandler(this.DgvFairs_SelectionChanged);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 799);
            this.Controls.Add(this.TbcEmployeeDashboard);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.TbcEmployeeDashboard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.FlpReportButtons.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDelayDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcEmployeeDashboard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAddService;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Button BtnAddLocation;
        private System.Windows.Forms.Button BtnAddBuilding;
        private System.Windows.Forms.Button BtnExitUpdate;
        private System.Windows.Forms.Button BtnUpdateService;
        private System.Windows.Forms.Button BtnUpdateEmployee;
        private System.Windows.Forms.Button BtnUpdateLocation;
        private System.Windows.Forms.Button BtnUpdateBuilding;
        private System.Windows.Forms.FlowLayoutPanel FlpReportButtons;
        private System.Windows.Forms.ListBox LstReportResults;
        private System.Windows.Forms.Button BtnExitReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEmployeeReport;
        private System.Windows.Forms.Button BtnServiceReport;
        private System.Windows.Forms.Button BtnBuildingReport;
        private System.Windows.Forms.Button BtnLocationReport;
        private System.Windows.Forms.Button BtnMevcutFuarlar;
        private System.Windows.Forms.Button BtnFuarOdemeleri;
        private System.Windows.Forms.DataGridView DgvFairs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDelayReason;
        private System.Windows.Forms.NumericUpDown NudDelayDuration;
        private System.Windows.Forms.Label LblSelectedFairDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LstDelayHistory;
        private System.Windows.Forms.Button BtnViewDelays;
        private System.Windows.Forms.Button BtnSaveDelay;
    }
}