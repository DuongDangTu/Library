using Qltv_lg.Data_bs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace Qltv_lg.Sach
{
    public partial class Uc_Menu_Reader : UserControl
    {
        Model1 db = new Model1();
        public Uc_Menu_Reader()
        {
            InitializeComponent();
            LoadData();
            //Search_PBG();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            UcReaders_Managerment ucReaders_Managerment = new UcReaders_Managerment();
            Add_UserControl.Add_UserControls(ucReaders_Managerment, Pn_Menu_Reader);
        }

      

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UcLoan_Managerment ucLoan_Managerment = new UcLoan_Managerment();
            Add_UserControl.Add_UserControls(ucLoan_Managerment, Pn_Menu_Reader);
        }
        void LoadData()
        {
            listViewHistory.Columns.Add("Mã Độc Giả", 50);
            listViewHistory.Columns.Add("Họ Tên", 100);
            listViewHistory.Columns.Add("Ngày Sinh", 100);
            listViewHistory.Columns.Add("Đối Tượng", 50);
            listViewHistory.Columns.Add("Mã Sách", 50);
            listViewHistory.Columns.Add("Tên Sách", 150);
            listViewHistory.Columns.Add("Tên tác giả", 150);
            listViewHistory.Columns.Add("Ngày Mượn", 100);
            listViewHistory.Columns.Add("Tình Trạng Giao", 100);
            listViewHistory.Columns.Add("Dự Kiến Trả", 100);

            var result = db.Database.SqlQuery<History_borrow_Result>("select * from History_borrow()").ToList();
            foreach (var item in result)
            {
                ListViewItem listView = new ListViewItem(item.mathedocgia.ToString());
                listView.SubItems.Add(item.hoten.ToString());
                listView.SubItems.Add(item.ngaysinh.ToString());
                listView.SubItems.Add(item.doituongdocgia.ToString());
                listView.SubItems.Add(item.maquyensach.ToString());
                listView.SubItems.Add(item.tendausach.ToString());
                listView.SubItems.Add(item.tentacgia.ToString());
                listView.SubItems.Add(item.ngaymuon.ToString());
                listView.SubItems.Add(item.tinhtrangkhigiao.ToString());
                listView.SubItems.Add(item.ngaydukientra.ToString());
                this.listViewHistory.Items.Add(listView);

            }
        }
            void Search_PBG()
            {
            string value = textSearchDS.Text;
            listViewHistory.Clear();
            listViewHistory.Columns.Add("Mã Độc Giả", 50);
            listViewHistory.Columns.Add("Họ Tên", 100);
            listViewHistory.Columns.Add("Ngày Sinh", 100);
            listViewHistory.Columns.Add("Đối Tượng", 50);
            listViewHistory.Columns.Add("Mã Sách", 50);
            listViewHistory.Columns.Add("Tên Sách", 150);
            listViewHistory.Columns.Add("Tên tác giả", 150);
            listViewHistory.Columns.Add("Ngày Mượn", 100);
            listViewHistory.Columns.Add("Tình Trạng Giao", 100);
            listViewHistory.Columns.Add("Dự Kiến Trả", 100);
            //int value = Convert.ToInt32(textSearchDS.Text);
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("name", value));
            var result = db.Database.SqlQuery<History_borrow_Result>("exec USPsearch_DGMuon @name", sqlParameters.ToArray()).ToList();
            foreach (var item in result)
            {
                ListViewItem listView = new ListViewItem(item.mathedocgia.ToString());
                listView.SubItems.Add(item.hoten.ToString());
                listView.SubItems.Add(item.ngaysinh.ToString());
                listView.SubItems.Add(item.doituongdocgia.ToString());
                listView.SubItems.Add(item.maquyensach.ToString());
                listView.SubItems.Add(item.tendausach.ToString());
                listView.SubItems.Add(item.tentacgia.ToString());
                listView.SubItems.Add(item.ngaymuon.ToString());
                listView.SubItems.Add(item.tinhtrangkhigiao.ToString());
                listView.SubItems.Add(item.ngaydukientra.ToString());
                this.listViewHistory.Items.Add(listView);

            }
        }

        private void textSearchDS_Enter(object sender, EventArgs e)
        {
            if (textSearchDS.Text == "Search")
            {
                textSearchDS.Text = "";
                textSearchDS.ForeColor = Color.Black;
            }
        }

        private void textSearchDS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search_PBG();
            }catch(Exception ex) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textSearchDS.Text == "Search")
                {
                    List<SqlParameter> sqlParameters = new List<SqlParameter>();
                    sqlParameters.Add(new SqlParameter("iddocgia", int.Parse(this.listViewHistory.SelectedItems[0].SubItems[0].Text)));
                    sqlParameters.Add(new SqlParameter("maqsach", int.Parse(this.listViewHistory.SelectedItems[0].SubItems[4].Text)));
                    var result = db.Database.SqlQuery<Report_muon_Result>("select * from Report_muon (@iddocgia , @maqsach)", sqlParameters.ToArray()).ToList();
                    CrystalReport1 crystalReport1 = new CrystalReport1();
                    crystalReport1.SetDataSource(result);
                    Form_RpMuonSach form_RpMuonSach = new Form_RpMuonSach();
                    form_RpMuonSach.crystalReportViewer1.ReportSource = crystalReport1;
                    form_RpMuonSach.ShowDialog();
                }
                else if (this.listViewHistory.SelectedItems[0].SubItems[0].Text == textSearchDS.Text)
                {
                    List<SqlParameter> sqlParameters = new List<SqlParameter>();
                    sqlParameters.Add(new SqlParameter("iddocgia", int.Parse(this.listViewHistory.SelectedItems[0].SubItems[0].Text)));
                    sqlParameters.Add(new SqlParameter("ngmuon", Convert.ToDateTime(this.listViewHistory.SelectedItems[0].SubItems[7].Text)));
                    /* List<SqlParameter> sqlParameters = new List<SqlParameter>();
                       sqlParameters.Add(new SqlParameter("iddocgia", int.Parse(this.listViewHistory.SelectedItems[0].SubItems[0].Text)));
                       sqlParameters.Add(new SqlParameter("maqsach", int.Parse(this.listViewHistory.SelectedItems[0].SubItems[7].Text)));*/
                    var result = db.Database.SqlQuery<Report_muon_nQuyen_Result>("select * from Report_muon_nQuyen (@iddocgia , @ngmuon)", sqlParameters.ToArray()).ToList();
                    CrystalReport1 crystalReport1 = new CrystalReport1();
                    crystalReport1.SetDataSource(result);
                    Form_RpMuonSach form_RpMuonSach = new Form_RpMuonSach();
                    form_RpMuonSach.crystalReportViewer1.ReportSource = crystalReport1;
                    form_RpMuonSach.ShowDialog();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Bạn cần chọn độc giả để report", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            
        }
        private void xuatfileExcel()
        {
        
        }
        private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_xuatExcel_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter="Excel workbook|*.xls",ValidateNames= true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "mathedocgia";
                    ws.Cells[1, 2] = "hoten";
                    ws.Cells[1, 3] = "ngaysinh";
                    ws.Cells[1, 4] = "doituongdocgia";
                    ws.Cells[1, 5] = "maquyensach";
                    ws.Cells[1, 6] = "tendausach";
                    ws.Cells[1, 7] = "tentacgia";
                    ws.Cells[1, 8] = "ngaymuon";
                    ws.Cells[1, 9] = "tinhtrangkhigiao";
                    ws.Cells[1, 10]= "ngaydukientra";
                    int i = 2;
                    foreach(ListViewItem item in listViewHistory.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        ws.Cells[i, 7] = item.SubItems[6].Text;
                        ws.Cells[i, 8] = item.SubItems[7].Text;
                        ws.Cells[i, 9] = item.SubItems[8].Text;
                        ws.Cells[i, 10]= item.SubItems[9].Text; 
                    }
                    wb.SaveAs(saveFileDialog.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Your Data Successfully exporter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
        }
    }
}
