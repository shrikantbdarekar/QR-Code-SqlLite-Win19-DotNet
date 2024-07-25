
namespace QRSqlLiteWin19
{
    partial class FormReportViewer
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelQRTestImage = new System.Windows.Forms.Panel();
            this.textBoxQRTestDate = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(472, 454);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panelQRTestImage
            // 
            this.panelQRTestImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelQRTestImage.Location = new System.Drawing.Point(564, 12);
            this.panelQRTestImage.Name = "panelQRTestImage";
            this.panelQRTestImage.Size = new System.Drawing.Size(117, 117);
            this.panelQRTestImage.TabIndex = 4;
            this.panelQRTestImage.Visible = false;
            // 
            // textBoxQRTestDate
            // 
            this.textBoxQRTestDate.Location = new System.Drawing.Point(12, 12);
            this.textBoxQRTestDate.Multiline = true;
            this.textBoxQRTestDate.Name = "textBoxQRTestDate";
            this.textBoxQRTestDate.Size = new System.Drawing.Size(436, 117);
            this.textBoxQRTestDate.TabIndex = 5;
            this.textBoxQRTestDate.Text = "Location name : Maintenance Room | Fel no. : 215 | Type of extinguisher : ABC 6kg" +
    " | Mfg & Year : Vintex 2017 | HPT : 9.12.2021 | Refilled : 9.12.2021 | Refill Du" +
    "e on : 8.12.2024 | ID: 987-778";
            this.textBoxQRTestDate.Visible = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(454, 56);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 23);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Visible = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // FormReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 454);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxQRTestDate);
            this.Controls.Add(this.panelQRTestImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Printing";
            this.Load += new System.EventHandler(this.FormReportViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panelQRTestImage;
        private System.Windows.Forms.TextBox textBoxQRTestDate;
        private System.Windows.Forms.Button buttonGenerate;
    }
}