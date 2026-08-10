
using Qltv_lg.Data_Report;

namespace Qltv_lg.Sach
{
    partial class MatSach
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
            this.functionlistSachLOSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVMATTERByHPXCDataSet = new Qltv_lg.Data_Report.QLTVMATTERByHPXC_2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.function_listSachLOSSTableAdapter = new Qltv_lg.Data_Report.QLTVMATTERByHPXC_2DataSetTableAdapters.function_listSachLOSSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.functionlistSachLOSSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVMATTERByHPXCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // functionlistSachLOSSBindingSource
            // 
            this.functionlistSachLOSSBindingSource.DataMember = "function_listSachLOSS";
            this.functionlistSachLOSSBindingSource.DataSource = this.qLTVMATTERByHPXCDataSet;
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
            reportDataSource1.Value = this.functionlistSachLOSSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Qltv_lg.Report.matsach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1141, 490);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // function_listSachLOSSTableAdapter
            // 
            this.function_listSachLOSSTableAdapter.ClearBeforeFill = true;
            // 
            // MatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 490);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MatSach";
            this.Text = "MatSach";
            this.Load += new System.EventHandler(this.MatSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.functionlistSachLOSSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVMATTERByHPXCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLTVMATTERByHPXC_2DataSet qLTVMATTERByHPXCDataSet;
        private System.Windows.Forms.BindingSource functionlistSachLOSSBindingSource;
        private Data_Report.QLTVMATTERByHPXC_2DataSetTableAdapters.function_listSachLOSSTableAdapter function_listSachLOSSTableAdapter;
    }
}