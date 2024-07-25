
namespace QRSqlLiteWin19
{
    partial class FormQRCodeSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.buttonQRReport = new System.Windows.Forms.Button();
            this.dataGridViewQRData = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.dgcQRDataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcQRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPrintQR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQRData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.buttonQRReport);
            this.panelContainer.Controls.Add(this.dataGridViewQRData);
            this.panelContainer.Controls.Add(this.buttonEdit);
            this.panelContainer.Controls.Add(this.buttonDelete);
            this.panelContainer.Controls.Add(this.buttonAddNew);
            this.panelContainer.Location = new System.Drawing.Point(12, 12);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1238, 478);
            this.panelContainer.TabIndex = 0;
            // 
            // buttonQRReport
            // 
            this.buttonQRReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQRReport.Location = new System.Drawing.Point(1083, 13);
            this.buttonQRReport.Name = "buttonQRReport";
            this.buttonQRReport.Size = new System.Drawing.Size(139, 23);
            this.buttonQRReport.TabIndex = 4;
            this.buttonQRReport.Text = "Print All QR";
            this.buttonQRReport.UseVisualStyleBackColor = true;
            this.buttonQRReport.Click += new System.EventHandler(this.buttonQRReport_Click);
            // 
            // dataGridViewQRData
            // 
            this.dataGridViewQRData.AllowUserToAddRows = false;
            this.dataGridViewQRData.AllowUserToResizeRows = false;
            this.dataGridViewQRData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQRData.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewQRData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewQRData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQRData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcQRDataId,
            this.dgcQRDate,
            this.dgcDataColumn1,
            this.dgcDataColumn2,
            this.dgcDataColumn3,
            this.dgcDataColumn4,
            this.dgcDataColumn5,
            this.dgcDataColumn6,
            this.dgcDataColumn7,
            this.dgcDataColumn8,
            this.dgcDataColumn9,
            this.dgcDataColumn10,
            this.dgcPrintQR});
            this.dataGridViewQRData.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewQRData.Name = "dataGridViewQRData";
            this.dataGridViewQRData.ReadOnly = true;
            this.dataGridViewQRData.Size = new System.Drawing.Size(1232, 433);
            this.dataGridViewQRData.TabIndex = 3;
            this.dataGridViewQRData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQRData_CellContentClick);
            this.dataGridViewQRData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewQRData_RowHeaderMouseDoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(95, 13);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(176, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(14, 13);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // dgcQRDataId
            // 
            this.dgcQRDataId.DataPropertyName = "QRDataId";
            this.dgcQRDataId.HeaderText = "QRDataId";
            this.dgcQRDataId.Name = "dgcQRDataId";
            this.dgcQRDataId.ReadOnly = true;
            // 
            // dgcQRDate
            // 
            this.dgcQRDate.DataPropertyName = "QRDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dgcQRDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcQRDate.HeaderText = "QR Date";
            this.dgcQRDate.Name = "dgcQRDate";
            this.dgcQRDate.ReadOnly = true;
            // 
            // dgcDataColumn1
            // 
            this.dgcDataColumn1.DataPropertyName = "DataColumn1";
            this.dgcDataColumn1.HeaderText = "DataColumn1";
            this.dgcDataColumn1.Name = "dgcDataColumn1";
            this.dgcDataColumn1.ReadOnly = true;
            // 
            // dgcDataColumn2
            // 
            this.dgcDataColumn2.DataPropertyName = "DataColumn2";
            this.dgcDataColumn2.HeaderText = "DataColumn2";
            this.dgcDataColumn2.Name = "dgcDataColumn2";
            this.dgcDataColumn2.ReadOnly = true;
            // 
            // dgcDataColumn3
            // 
            this.dgcDataColumn3.DataPropertyName = "DataColumn3";
            this.dgcDataColumn3.HeaderText = "DataColumn3";
            this.dgcDataColumn3.Name = "dgcDataColumn3";
            this.dgcDataColumn3.ReadOnly = true;
            // 
            // dgcDataColumn4
            // 
            this.dgcDataColumn4.DataPropertyName = "DataColumn4";
            this.dgcDataColumn4.HeaderText = "DataColumn4";
            this.dgcDataColumn4.Name = "dgcDataColumn4";
            this.dgcDataColumn4.ReadOnly = true;
            // 
            // dgcDataColumn5
            // 
            this.dgcDataColumn5.DataPropertyName = "DataColumn5";
            this.dgcDataColumn5.HeaderText = "DataColumn5";
            this.dgcDataColumn5.Name = "dgcDataColumn5";
            this.dgcDataColumn5.ReadOnly = true;
            // 
            // dgcDataColumn6
            // 
            this.dgcDataColumn6.DataPropertyName = "DataColumn6";
            dataGridViewCellStyle5.Format = "d";
            this.dgcDataColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgcDataColumn6.HeaderText = "DataColumn6";
            this.dgcDataColumn6.Name = "dgcDataColumn6";
            this.dgcDataColumn6.ReadOnly = true;
            // 
            // dgcDataColumn7
            // 
            this.dgcDataColumn7.DataPropertyName = "DataColumn7";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dgcDataColumn7.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgcDataColumn7.HeaderText = "DataColumn7";
            this.dgcDataColumn7.Name = "dgcDataColumn7";
            this.dgcDataColumn7.ReadOnly = true;
            // 
            // dgcDataColumn8
            // 
            this.dgcDataColumn8.DataPropertyName = "DataColumn8";
            this.dgcDataColumn8.HeaderText = "DataColumn8";
            this.dgcDataColumn8.Name = "dgcDataColumn8";
            this.dgcDataColumn8.ReadOnly = true;
            // 
            // dgcDataColumn9
            // 
            this.dgcDataColumn9.DataPropertyName = "DataColumn9";
            this.dgcDataColumn9.HeaderText = "DataColumn9";
            this.dgcDataColumn9.Name = "dgcDataColumn9";
            this.dgcDataColumn9.ReadOnly = true;
            // 
            // dgcDataColumn10
            // 
            this.dgcDataColumn10.DataPropertyName = "DataColumn10";
            this.dgcDataColumn10.HeaderText = "DataColumn10";
            this.dgcDataColumn10.Name = "dgcDataColumn10";
            this.dgcDataColumn10.ReadOnly = true;
            // 
            // dgcPrintQR
            // 
            this.dgcPrintQR.HeaderText = "Print QR";
            this.dgcPrintQR.Name = "dgcPrintQR";
            this.dgcPrintQR.ReadOnly = true;
            this.dgcPrintQR.Text = "Print QR";
            this.dgcPrintQR.UseColumnTextForButtonValue = true;
            // 
            // FormQRCodeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 502);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormQRCodeSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQRCodeSearch_Load);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQRData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.DataGridView dataGridViewQRData;
        private System.Windows.Forms.Button buttonQRReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQRDataId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQRDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataColumn10;
        private System.Windows.Forms.DataGridViewButtonColumn dgcPrintQR;
    }
}