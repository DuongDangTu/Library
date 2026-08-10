
using Qltv_lg.Data_Report;

namespace Qltv_lg.Sach
{
    partial class BaoCaoThongKE
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
            this.functhongkeTTQSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVMATTERByHPXCDataSet = new Qltv_lg.Data_Report.QLTVMATTERByHPXC_2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.functhongkeTTQSTableAdapter = new Qltv_lg.Data_Report.QLTVMATTERByHPXC_2DataSetTableAdapters.functhongkeTTQSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.functhongkeTTQSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVMATTERByHPXCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // functhongkeTTQSBindingSource
            // 
            this.functhongkeTTQSBindingSource.DataMember = "functhongkeTTQS";
            this.functhongkeTTQSBindingSource.DataSource = this.qLTVMATTERByHPXCDataSet;
            // 
            // qLTVMATTERByHPXCDataSet
            // 
            this.qLTVMATTERByHPXCDataSet.DataSetName = "QLTVMATTERByHPXCDataSet";
            this.qLTVMATTERByHPXCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.functhongkeTTQSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Qltv_lg.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1359, 700);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // functhongkeTTQSTableAdapter
            // 
            this.functhongkeTTQSTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoThongKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 700);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaoThongKE";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.functhongkeTTQSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVMATTERByHPXCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLTVMATTERByHPXC_2DataSet qLTVMATTERByHPXCDataSet;
        private System.Windows.Forms.BindingSource functhongkeTTQSBindingSource;
        private Data_Report.QLTVMATTERByHPXC_2DataSetTableAdapters.functhongkeTTQSTableAdapter functhongkeTTQSTableAdapter;
    }
}