
using Qltv_lg.Data_Report;

namespace Qltv_lg.Sach
{
    partial class THongKeTop
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
            this.tbdausachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVMATTERByHPXCDataSet = new Qltv_lg.Data_Report.QLTVMATTERByHPXC_2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_dausachTableAdapter = new Qltv_lg.Data_Report.QLTVMATTERByHPXC_2DataSetTableAdapters.tb_dausachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbdausachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVMATTERByHPXCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbdausachBindingSource
            // 
            this.tbdausachBindingSource.DataMember = "tb_dausach";
            this.tbdausachBindingSource.DataSource = this.qLTVMATTERByHPXCDataSet;
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
            reportDataSource1.Value = this.tbdausachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Qltv_lg.Report.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1255, 535);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tb_dausachTableAdapter
            // 
            this.tb_dausachTableAdapter.ClearBeforeFill = true;
            // 
            // THongKeTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 535);
            this.Controls.Add(this.reportViewer1);
            this.Name = "THongKeTop";
            this.Text = "THongKeTop";
            this.Load += new System.EventHandler(this.THongKeTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbdausachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVMATTERByHPXCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLTVMATTERByHPXC_2DataSet qLTVMATTERByHPXCDataSet;
        private System.Windows.Forms.BindingSource tbdausachBindingSource;
        private Data_Report.QLTVMATTERByHPXC_2DataSetTableAdapters.tb_dausachTableAdapter tb_dausachTableAdapter;
    }
}