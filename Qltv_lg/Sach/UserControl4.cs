using Qltv_lg.Data_bs;
using Qltv_lg.SqlServerTypes;
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

namespace Qltv_lg.Sach
{

    public partial class UcReaders_Managerment : UserControl
    {
        Model1 db = new Model1();
        public UcReaders_Managerment()
        {
            InitializeComponent();
            loadData();
        }

        private void Readers_Managerment_Load(object sender, EventArgs e)
        {
           
        }
        void loadData()
        {
            listViewDG.Clear();
            listViewDG.Columns.Add("ID", 50);
            listViewDG.Columns.Add("Tên Độc Giả", 200);
            listViewDG.Columns.Add("Địa Chỉ", 150);
            listViewDG.Columns.Add("Đối Tượng Độc Giả", 120);
            listViewDG.Columns.Add("Ngày Sinh", 100);
            listViewDG.Columns.Add("Ngày Làm Thẻ", 100);

            var Result = db.tb_docgia.ToList();

            foreach (var item in Result)
            {
                ListViewItem listViewItem = new ListViewItem(item.mathedocgia.ToString());
                listViewItem.SubItems.Add(item.hoten.ToString());
                listViewItem.SubItems.Add(item.diachi.ToString());
                listViewItem.SubItems.Add(item.doituongdocgia.ToString());
                listViewItem.SubItems.Add(item.ngaysinh.ToString());
                listViewItem.SubItems.Add(item.ngaylamthe.ToString());
                listViewItem.Tag = item.mathedocgia;
                this.listViewDG.Items.Add(listViewItem);

            }
        }

        void LoadDataDauSachbyDG()
        {
            
            int id=Convert.ToInt32(this.listViewDG.SelectedItems[0].SubItems[0].Text);
            List<SqlParameter> paramlist = new List<SqlParameter>();
            paramlist.Add(new SqlParameter("idmadocgia",id));
            var rs=db.Database.SqlQuery<fun_loadAlLDSbyDocGia_Result>("select * from fun_loadAlLDSbyDocGia(@idmadocgia)", paramlist.ToArray());

            listView1.Clear();
            listView1.Columns.Add("ma sach", 100);
            listView1.Columns.Add("Tên Sách", 200);
            listView1.Columns.Add("số trang", 150);

            foreach (var item in rs)
            {
                ListViewItem listViewItem = new ListViewItem(item.maquyensach.ToString());
                listViewItem.SubItems.Add(item.tendausach.ToString());
                listViewItem.SubItems.Add(item.sotrang.ToString());
                this.listView1.Items.Add(listViewItem);

            }
        }

        private void listViewDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //txt_idtg.Text = this.listViewDG.SelectedItems[0].SubItems[0].Text;
                //txt_nametg.Text = this.listViewDG.SelectedItems[0].SubItems[1].Text;
                //txt_diachitg.Text = this.listViewDG.SelectedItems[0].SubItems[2].Text;
                //txt_doituong.Text = this.listViewDG.SelectedItems[0].SubItems[3].Text;
                //dateTime_DateofBirth.Value = Convert.ToDateTime(this.listViewDG.SelectedItems[0].SubItems[4].Text);
                //dateTime_dateofCard.Value = Convert.ToDateTime(this.listViewDG.SelectedItems[0].SubItems[5].Text);
                //LoadDataDauSachbyDG();
                List<SqlParameter> paramlist = new List<SqlParameter>();
                int id = Convert.ToInt32(this.listViewDG.SelectedItems[0].SubItems[0].Text);
                paramlist.Add(new SqlParameter("madocgia", id));
                var rs = db.Database.SqlQuery<Nullable<int>>("exec USP_DocGiaBiPhat @madocgia", paramlist.ToArray()).ToList();

                if (rs[0] == 1)
                {
                    btn_Unlock.Visible = true;
                    MessageBox.Show("Độc giả đã bị khóa ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    btn_Unlock.Visible = false;
                    txt_idtg.Text = this.listViewDG.SelectedItems[0].SubItems[0].Text;
                    txt_nametg.Text = this.listViewDG.SelectedItems[0].SubItems[1].Text;
                    txt_diachitg.Text = this.listViewDG.SelectedItems[0].SubItems[2].Text;
                    txt_doituong.Text = this.listViewDG.SelectedItems[0].SubItems[3].Text;
                    dateTime_DateofBirth.Value = Convert.ToDateTime(this.listViewDG.SelectedItems[0].SubItems[4].Text);
                    dateTime_dateofCard.Value = Convert.ToDateTime(this.listViewDG.SelectedItems[0].SubItems[5].Text);
                    LoadDataDauSachbyDG();
                }
            }
            catch
            {

            }
        }
        void newTXT()
        {
            txt_idtg.Text = "";
            txt_nametg.Text = "";
            txt_diachitg.Text = "";
            txt_doituong.Text = "";
            dateTime_DateofBirth.Value = DateTime.Now;
            dateTime_dateofCard.Value = DateTime.Now;
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            newTXT();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string tendocgia = txt_nametg.Text;
            string diachi = txt_diachitg.Text;
            string doituong = txt_doituong.Text;
            DateTime ngaysinh = dateTime_DateofBirth.Value;
            DateTime ngaylamthe = dateTime_dateofCard.Value;


            tb_docgia emp = new tb_docgia() { hoten = tendocgia, diachi = diachi,doituongdocgia= doituong,ngaysinh=ngaysinh,ngaylamthe=ngaylamthe };
            db.tb_docgia.Add(emp);
            db.SaveChanges();
            loadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //string id1 = listView1.SelectedItems[0].SubItems[0].Text;
                int id = int.Parse(listViewDG.SelectedItems[0].SubItems[0].Text);
                // db.Database.ExecuteSqlCommand("delete tb_docgia where mathedocgia="+id);
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("iddocgia", id));
                db.Database.ExecuteSqlCommand("exec Delete_DocGia_ @iddocgia ", sqlParameters.ToArray());
/*                if (id1 =="" )
                {
                    MessageBox.Show("Xóa Thành Công");
                }*/
                newTXT();
                loadData();

            }
            catch(Exception ex )
            {
                MessageBox.Show("ok lỗi rồi ");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {/*
            string value = txt_searchID.Text;
            if (!string.IsNullOrEmpty(value))
            {
                var result = db.USPsearch_tenDocGia(value);
                foreach (var item in result)
                {
                    ListViewItem listViewItem = new ListViewItem(item.mathedocgia.ToString());
                    listViewItem.SubItems.Add(item.hoten.ToString());
                    listViewItem.SubItems.Add(item.diachi.ToString());
                    listViewItem.SubItems.Add(item.doituongdocgia.ToString());
                    listViewItem.SubItems.Add(item.ngaysinh.ToString());
                    listViewItem.SubItems.Add(item.ngaylamthe.ToString());
                    this.listViewDG.Items.Add(listViewItem);
                }
            }
            else
            {
                loadData();
            }*/
        }

      

        private void txt_search_Leave(object sender, EventArgs e)
        {
         
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_searchID.Text == "Search")
            {
                txt_searchID.Text = "";
                txt_searchID.ForeColor = Color.Black; 
            }
        }

        private void txt_searchID_TextChanged(object sender, EventArgs e)
        {
            listViewDG.Clear();
            listViewDG.Columns.Add("ID", 50);
            listViewDG.Columns.Add("Tên Tác Giả", 150);
            listViewDG.Columns.Add("Địa Chỉ", 100);
            listViewDG.Columns.Add("Đối Tượng Độc Giả", 100);
            listViewDG.Columns.Add("Ngày Sinh", 100);
            listViewDG.Columns.Add("Ngày Làm Thẻ", 100);
            string value = txt_searchID.Text;
            if (!string.IsNullOrEmpty(value))
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("name", value));
                var result = db.Database.SqlQuery<USPsearch_tenDocGia_Result>("exec USPsearch_tenDocGia @name", sqlParameters.ToArray());
                foreach (var item in result)
                {
                    ListViewItem listViewItem = new ListViewItem(item.mathedocgia.ToString());
                    listViewItem.SubItems.Add(item.hoten.ToString());
                    listViewItem.SubItems.Add(item.diachi.ToString());
                    listViewItem.SubItems.Add(item.doituongdocgia.ToString());
                    listViewItem.SubItems.Add(item.ngaysinh.ToString());
                    listViewItem.SubItems.Add(item.ngaylamthe.ToString());
                    this.listViewDG.Items.Add(listViewItem);
                }
            }
            else
            {
                loadData();
            }
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("iddocgia", int.Parse(txt_idtg.Text)));
                sqlParameters.Add(new SqlParameter("name", txt_nametg.Text));
                sqlParameters.Add(new SqlParameter("ngsinh", Convert.ToDateTime(dateTime_DateofBirth.Text)));
                sqlParameters.Add(new SqlParameter("nglamthe",Convert.ToDateTime(dateTime_dateofCard.Text)));
                sqlParameters.Add(new SqlParameter("dchi", txt_diachitg.Text));
                sqlParameters.Add(new SqlParameter("doituongdocgia", txt_doituong.Text));
                // sqlParameters.Add(new SqlParameter("tinhtrang", 0));
                //exec Repair  @iddocgia  , @name  , @ngsinh , @nglamthe   , @dchi 
                var rs = db.Database.SqlQuery<RS_Result>("exec Repair @iddocgia  , @name  , @ngsinh  , @nglamthe    , @dchi , @doituongdocgia  ",sqlParameters.ToArray()).ToList();
                // int rs = Convert.ToInt32(result);
                if (rs[0].rs_RS == 0)
                {
                    MessageBox.Show("sửa thành công");
                    loadData();
                }else if(rs[0].rs_RS == 2)
                {
                    MessageBox.Show("Không thể xóa do độc giả này đã mượn sách ");
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if (infoStatic.Quyen_ == 1)
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("iddocgia", int.Parse(this.listViewDG.SelectedItems[0].SubItems[0].Text)));

                var result = db.Database.SqlQuery<tb_docgia>("select * from tb_docgia where tb_docgia.mathedocgia = @iddocgia", sqlParameters.ToArray()).ToList();

                CrystalReport5 crystalReport5 = new CrystalReport5();
                crystalReport5.SetDataSource(result);
                Form_RpMuonSach fm = new Form_RpMuonSach();
                fm.crystalReportViewer1.ReportSource = crystalReport5;
                fm.ShowDialog();
            }
            else if(infoStatic.Quyen_ == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập tai đây");
            }
        }

        private void btn_Unlock_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.listViewDG.SelectedItems[0].SubItems[0].Text);
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("idmathedocgia", id));
            db.Database.ExecuteSqlCommand("USP_MoKhoaTheDocGia @idmathedocgia", sqlParameters.ToArray());
            MessageBox.Show("Mở Khóa Thành Công");
        }
        //sqlParameters.Add(new SqlParameter 

    }
    }


