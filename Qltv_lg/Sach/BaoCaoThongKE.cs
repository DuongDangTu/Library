using Qltv_lg.Data_bs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qltv_lg.Sach
{
    public partial class BaoCaoThongKE : Form
    {
        public BaoCaoThongKE()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
        void HienThiREPORT()
        {
            //reportViewer1
            var rs = db.Database.SqlQuery<functhongkeTTQS_Result>("select * from functhongkeTTQS()");
            functhongkeTTQSBindingSource.DataSource = rs.ToList();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVMATTERByHPXCDataSet.functhongkeTTQS' table. You can move, or remove it, as needed.
            this.functhongkeTTQSTableAdapter.Fill(this.qLTVMATTERByHPXCDataSet.functhongkeTTQS);
            // TODO: This line of code loads data into the 'qLTVMATTERByHPXCDataSet.functhongkeTTQS' table. You can move, or remove it, as needed.
            this.functhongkeTTQSTableAdapter.Fill(this.qLTVMATTERByHPXCDataSet.functhongkeTTQS);

            HienThiREPORT();

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
