namespace Project
{
    partial class SellerReports
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
            this.SalesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.projectDataSet = new Project.ProjectDataSet();
            this.sellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellerTableAdapter = new Project.ProjectDataSetTableAdapters.SellerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesReportViewer
            // 
            this.SalesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.SalesReportViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesReportViewer.Name = "SalesReportViewer";
            this.SalesReportViewer.ServerReport.BearerToken = null;
            this.SalesReportViewer.Size = new System.Drawing.Size(1200, 692);
            this.SalesReportViewer.TabIndex = 0;
            this.SalesReportViewer.Load += new System.EventHandler(this.SalesReportViewer_Load);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Seller";
            reportDataSource1.Value = this.sellerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.SellerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 692);
            this.reportViewer1.TabIndex = 1;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellerBindingSource
            // 
            this.sellerBindingSource.DataMember = "Seller";
            this.sellerBindingSource.DataSource = this.projectDataSet;
            // 
            // sellerTableAdapter
            // 
            this.sellerTableAdapter.ClearBeforeFill = true;
            // 
            // SellerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.SalesReportViewer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellerReports";
            this.Text = "Seller Reports";
            this.Load += new System.EventHandler(this.SellerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer SalesReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource sellerBindingSource;
        private ProjectDataSetTableAdapters.SellerTableAdapter sellerTableAdapter;
    }
}