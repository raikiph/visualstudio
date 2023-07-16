namespace frmnhaccu
{
    partial class frmReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.QLNCDataSet = new frmnhaccu.QLNCDataSet();
            this.INCHITIETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INCHITIETTableAdapter = new frmnhaccu.QLNCDataSetTableAdapters.INCHITIETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLNCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INCHITIETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.INCHITIETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmnhaccu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(734, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma Hoa Don";
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(117, 11);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(121, 21);
            this.cboMaHD.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(394, 10);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // QLNCDataSet
            // 
            this.QLNCDataSet.DataSetName = "QLNCDataSet";
            this.QLNCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // INCHITIETBindingSource
            // 
            this.INCHITIETBindingSource.DataMember = "INCHITIET";
            this.INCHITIETBindingSource.DataSource = this.QLNCDataSet;
            // 
            // INCHITIETTableAdapter
            // 
            this.INCHITIETTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 329);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cboMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INCHITIETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.BindingSource INCHITIETBindingSource;
        private QLNCDataSet QLNCDataSet;
        private QLNCDataSetTableAdapters.INCHITIETTableAdapter INCHITIETTableAdapter;

    }
}