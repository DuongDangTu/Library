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
    public partial class MatSach : Form
    {
        public MatSach()
        {
            InitializeComponent();
        }

        Model1 db = new Model1(); 
        void HienThiMAtSach()
        {
            var rs = db.Database.SqlQuery<function_listSachLOSS_Result>("select * from function_listSachLOSS()");
            foreach(var item in rs)
            {
                ListViewItem lsvItem = new ListViewItem(item.tinhtrangsach.ToString());
                string tinhtrang = ""; 
                if(item.tinhtrangsach == 3)
                {
                    tinhtrang = "đã mất";
                }
                lsvItem.SubItems.Add(tinhtrang);
            }
            functionlistSachLOSSBindingSource.DataSource = rs.ToList();
            

        }

        private void MatSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVMATTERByHPXCDataSet.function_listSachLOSS' table. You can move, or remove it, as needed.
            this.function_listSachLOSSTableAdapter.Fill(this.qLTVMATTERByHPXCDataSet.function_listSachLOSS);
            HienThiMAtSach();
            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
