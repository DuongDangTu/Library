using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
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
    public partial class UcBook_Managerment : UserControl
    {
        Model1 db = new Model1();
        //UcBook_Managerment ucBook = new UcBook_Managerment();
        //XtraForm Xtra = new XtraForm();
        public UcBook_Managerment()
        {
            InitializeComponent();
           
           
        }     
        private void HienthiBaoCaoThongKe()
        {
            var rs = db.Database.SqlQuery<function_listSachLOSS_Result>("select * from function_listSachLOSS()");
            // đường dẫn báo cáo 
            functionlistSachLOSSBindingSource2.DataSource = rs.ToList();


        }

        private void Buttonreportchart_Click(object sender, EventArgs e)
        {
            BaoCaoThongKE v = new BaoCaoThongKE();
            v.ShowDialog();
        }

        private void Buttonbaomatsach_Click(object sender, EventArgs e)
        {
            MatSach m = new MatSach();
            m.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            THongKeTop t = new THongKeTop();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongKeDocGia dg = new ThongKeDocGia();
            dg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa toàn bộ sách bị mất?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Database.ExecuteSqlCommand("exec [USP_DELETEBOOKLOSS]");
            }
            var rs = db.Database.SqlQuery<function_listSachLOSS_Result>("select * from function_listSachLOSS()");
            CrystalReport3 crystalReport3 = new CrystalReport3();
            crystalReport3.SetDataSource(rs);
            Form_RpMuonSach fm = new Form_RpMuonSach();
            fm.crystalReportViewer1.ReportSource = crystalReport3;
            fm.ShowDialog();

         
        }

        private void UcBook_Managerment_Load(object sender, EventArgs e)
        {
            timer_Yellow.Start();
            this.function_listSachLOSSTableAdapter1.Fill(this.qLTVMATTERByHPXC_2DataSet1.function_listSachLOSS);
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_Yellow_Tick(object sender, EventArgs e)
        {
            picture_Pica.Left += 2;
        }
    }
}
