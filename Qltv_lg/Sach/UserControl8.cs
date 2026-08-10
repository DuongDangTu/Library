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
    public partial class UcLoan_Managerment : UserControl
    {

        public UcLoan_Managerment()
        {
            InitializeComponent();
            LoadSearchDocGia();
            LoadSearchSach();
        }
        Model1 db = new Model1();

        private int maNhanVien;

        // void 
        void LoadSearchDocGia()
        {

            string strs = txt_searchID.Text;


            listViewdg.Clear();
            listViewdg.Columns.Add("ID ", 50);
            listViewdg.Columns.Add("Họ Tên", 200);

            List<SqlParameter> paramlist = new List<SqlParameter>();
            paramlist.Add(new SqlParameter("name", strs));
            var result = db.Database.SqlQuery<USPsearch_tenDocGia_Result>("exec USPsearch_tenDocGia @name", paramlist.ToArray());

            //var result = db.USPsearch_tenDocGia(strs);


            foreach (var item in result)
            {
                ListViewItem lsvItem = new ListViewItem(item.mathedocgia.ToString());
                lsvItem.SubItems.Add(item.hoten.ToString());

                lsvItem.Tag = item.mathedocgia;
                this.listViewdg.Items.Add(lsvItem);
            }

        }


        void LoadSearchSach()
        {
            string strs = text_searchSach.Text;

            try
            {
                listViewsach.Clear();
                listViewsach.Columns.Add("ID ", 50);
                listViewsach.Columns.Add("Tên Sách", 150);

                List<SqlParameter> paramlist = new List<SqlParameter>();
                paramlist.Add(new SqlParameter("name", strs));
                var result = db.Database.SqlQuery<USPsearch_Result>("exec USPsearch @name", paramlist.ToArray());
                // var result = db.USPsearch(strs);


                foreach (var item in result)
                {
                    ListViewItem lsvItem = new ListViewItem(item.maquyensach.ToString());
                    lsvItem.SubItems.Add(item.tendausach.ToString());
                    lsvItem.Tag = item.maquyensach;
                    this.listViewsach.Items.Add(lsvItem);
                }
            }
            catch (Exception ex) { }
        }

        void TXTNewRS()
        {
            txt_madg_01.Text = "";
            txt_masach_01.Text = "";
            datetimengaymuon.Text = "";
            dateTimengaytra.Text = "";
            txt_trangthaikhigiao.Text = "";
            txt_masach.Text = "";
            txt_madg.Text = "";
            txt_ngaysinh.Text = "";
            txt_diachi.Text = "";
            txt_doituong.Text = "";
            txt_ngaylmthe.Text = "";
            txt_ngaymuon.Text = "";
            txt_tendg.Text = "";
            txt_tentg.Text = "";
            lb_tennv.Text = "";
            //.Text = item.tennhanvien.ToString();
            txt_sotrang.Text = "";
            txt_trangthaikhigiao.Text = "";
            txt_vaitrotacgia.Text = "";
            txt_tensach.Text = "";
            txt_ngaytra.Text = "";

        }
        private void Btn_New_Click(object sender, EventArgs e)
        {
            TXTNewRS();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // txt_madg_01.Text = this.listViewdg.SelectedItems[0].SubItems[0].Text;

                List<SqlParameter> paramlist = new List<SqlParameter>();
                int id = Convert.ToInt32(this.listViewdg.SelectedItems[0].SubItems[0].Text);
                paramlist.Add(new SqlParameter("madocgia", id));
                var rs = db.Database.SqlQuery<Nullable<int>>("exec USP_DocGiaBiPhat @madocgia", paramlist.ToArray()).ToList();

                if (rs[0] == 1)
                {
                    MessageBox.Show("Không thể cho mượn vì bị phạt", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txt_madg_01.Text = this.listViewdg.SelectedItems[0].SubItems[0].Text;
                }

            }
            catch (Exception ex)
            {
            }

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_masach_01.Text = this.listViewsach.SelectedItems[0].SubItems[0].Text;
            }
            catch (Exception ex) { }

        }

        private void Btn_muon_Click(object sender, EventArgs e)
        {
            try
            {
                // ====== 1. KIỂM TRA DỮ LIỆU NHẬP ======
                if (string.IsNullOrEmpty(txt_tinhtrangkhigiao_01.Text))
                {
                    MessageBox.Show("Vui lòng nhập tình trạng giao sách!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txt_masach_01.Text))
                {
                    MessageBox.Show("Vui lòng chọn sách!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txt_madg_01.Text))
                {
                    MessageBox.Show("Vui lòng chọn bạn đọc!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ====== 2. LẤY DỮ LIỆU ======
                int maSach = int.Parse(txt_masach_01.Text);
                int maDocGia = int.Parse(txt_madg_01.Text);
                DateTime ngayMuon = datetimengaymuon.Value.Date;
                DateTime ngayTraDK = dateTimengaytra.Value.Date;

                // ====== 3. KIỂM TRA NGÀY MƯỢN/TRẢ ======
                if (ngayTraDK <= ngayMuon)
                {
                    MessageBox.Show("Ngày trả dự kiến phải lớn hơn ngày mượn!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ====== 4. KIỂM TRA SÁCH CÒN KHÔNG ======
                var sachCheck = db.Database.SqlQuery<int>(
                    "SELECT COUNT(*) FROM tb_sach WHERE maquyensach = @p0 AND tinhtrangsach = 1",
                    maSach
                ).FirstOrDefault();

                if (sachCheck == 0)
                {
                    MessageBox.Show("Sách đã được mượn hoặc không tồn tại!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ====== 5. KIỂM TRA BẠN ĐỌC CÓ BỊ PHẠT KHÔNG ======
                List<SqlParameter> paramCheck = new List<SqlParameter>();
                paramCheck.Add(new SqlParameter("madocgia", maDocGia));
                var rs = db.Database.SqlQuery<Nullable<int>>(
                    "exec USP_DocGiaBiPhat @madocgia",
                    paramCheck.ToArray()
                ).ToList();

                if (rs.Count > 0 && rs[0] == 1)
                {
                    MessageBox.Show("Bạn đọc đã bị khóa do vi phạm quá nhiều!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ====== 6. GỌI PROCEDURE MƯỢN SÁCH ======
                this.maNhanVien = 100; // Mã nhân viên mặc định

                List<SqlParameter> paramlist = new List<SqlParameter>();
                paramlist.Add(new SqlParameter("idSach", maSach));
                paramlist.Add(new SqlParameter("mathedocgia", maDocGia));
                paramlist.Add(new SqlParameter("manhanvien", this.maNhanVien));
                paramlist.Add(new SqlParameter("ngaymuon", ngayMuon));
                paramlist.Add(new SqlParameter("ngaydukientra", ngayTraDK));
                paramlist.Add(new SqlParameter("tinhtrangkhigiao", txt_tinhtrangkhigiao_01.Text));

                // Thực thi
                db.Database.ExecuteSqlCommand(
                    "exec USP_insertPhieuBanGiao @idSach, @mathedocgia, @manhanvien, @ngaymuon, @ngaydukientra, @tinhtrangkhigiao",
                    paramlist.ToArray()
                );

                // ====== 7. HIỂN THỊ PHIẾU MƯỢN ======
                var result = db.Database.SqlQuery<USP_PrintPhieuBanGiao1_Result>(
                    "select * from USP_PrintPhieuBanGiao1(@idSach, @mathedocgia, @manhanvien, @ngaymuon, @ngaydukientra, @tinhtrangkhigiao)",
                    paramlist.ToArray()
                ).ToList();

                foreach (var item in result)
                {
                    txt_masach.Text = item.maquyensach.ToString();
                    txt_madg.Text = item.mathedocgia.ToString();
                    txt_ngaysinh.Text = item.ngaysinh.ToString();
                    txt_diachi.Text = item.diachi.ToString();
                    txt_doituong.Text = item.doituongdocgia.ToString();
                    txt_ngaylmthe.Text = item.ngaylamthe.ToString();
                    txt_ngaymuon.Text = item.ngaymuon.ToString();
                    txt_tendg.Text = item.hoten.ToString();
                    txt_tentg.Text = item.tentacgia.ToString();
                    lb_tennv.Text = item.tennhanvien.ToString();
                    txt_sotrang.Text = item.sotrang.ToString();
                    txt_trangthaikhigiao.Text = item.tinhtrangkhigiao.ToString();
                    txt_vaitrotacgia.Text = "Chủ biên";
                    txt_tensach.Text = item.tendausach.ToString();
                    txt_ngaytra.Text = item.ngaydukientra.ToString();
                }

                MessageBox.Show($"Mượn sách thành công!\nNgày mượn: {ngayMuon:dd/MM/yyyy}\nNgày trả dự kiến: {ngayTraDK:dd/MM/yyyy}",
                               "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ====== 8. RESET FORM ======
                txt_madg_01.Text = "";
                txt_masach_01.Text = "";
                txt_tinhtrangkhigiao_01.Text = "";
                datetimengaymuon.Value = DateTime.Now;
                dateTimengaytra.Value = DateTime.Now.AddDays(30);
                LoadSearchDocGia();
                LoadSearchSach();
            }
            catch (SqlException sqlEx)
            {
                // Hiển thị lỗi SQL chi tiết
                string errorMsg = $"LỖI SQL:\n{sqlEx.Message}\n\nProcedure: {sqlEx.Procedure}\nLine: {sqlEx.LineNumber}";

                if (sqlEx.Message.Contains("sách không tồn tại") || sqlEx.Message.Contains("đã được mượn"))
                {
                    MessageBox.Show("Sách không tồn tại hoặc đã được mượn!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sqlEx.Message.Contains("bạn đọc không tồn tại"))
                {
                    MessageBox.Show("Bạn đọc không tồn tại!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sqlEx.Message.Contains("hết sách"))
                {
                    MessageBox.Show("Đã hết sách trong thư viện!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sqlEx.Message.Contains("ngày mượn") || sqlEx.Message.Contains("ngày trả"))
                {
                    MessageBox.Show("Ngày mượn/trả không hợp lệ!\nThời gian mượn tối thiểu là 1 ngày.", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(errorMsg, "Lỗi SQL Chi Tiết",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LỖI:\n{ex.Message}\n\n{ex.StackTrace}",
                               "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*void InsertPhieuBanGiao() { 
               if (txt_masach.Text == "" || txt_madg.Text == "" || txt_trangthaikhigiao.Text == "")
               {
                   MessageBox.Show("không thể cho mượn", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               else
               {

                   try
                   {
                       List<SqlParameter> paramlist1 = new List<SqlParameter>();
                       paramlist1.Add(new SqlParameter("idSach", int.Parse(txt_masach_01.Text)));
                       paramlist1.Add(new SqlParameter("mathedocgia", int.Parse(txt_madg_01.Text)));
                       paramlist1.Add(new SqlParameter("manhanvien", maNhanVien));
                       paramlist1.Add(new SqlParameter("ngaymuon", Convert.ToDateTime(datetimengaymuon.Text)));
                       paramlist1.Add(new SqlParameter("ngaydukientra", Convert.ToDateTime(dateTimengaytra.Text)));
                       paramlist1.Add(new SqlParameter("tinhtrangkhigiao", txt_tinhtrangkhigiao_01.Text));

                       db.Database.ExecuteSqlCommand("exec USP_insertPhieuBanGiao @idSach , @mathedocgia , @manhanvien , @ngaymuon , @ngaydukientra , @tinhtrangkhigiao", paramlist1.ToArray());
                       MessageBox.Show("Cho mượn Thành công");

                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Đã xảy ra lỗi trong quá trình mượn", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
               }
           }*/



        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_searchID_Enter(object sender, EventArgs e)
        {
            if (txt_searchID.Text == "Search")
            {
                txt_searchID.Text = "";
                txt_searchID.ForeColor = Color.Black;
            }
        }

        private void text_searchSach_Enter(object sender, EventArgs e)
        {
            if (text_searchSach.Text == "Search")
            {
                text_searchSach.Text = "";
                text_searchSach.ForeColor = Color.Black;
            }
        }

        private void txt_searchID_TextChanged_1(object sender, EventArgs e)
        {

            LoadSearchDocGia();

        }

        private void text_searchSach_TextChanged(object sender, EventArgs e)
        {
            LoadSearchSach();
        }

        private void txt_madg_01_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_masach.Text == "" || txt_madg.Text == "" || txt_trangthaikhigiao.Text == "")
            {
                MessageBox.Show("không thể cho mượn", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    this.maNhanVien = 100;
                    List<SqlParameter> paramlist = new List<SqlParameter>();
                    paramlist.Add(new SqlParameter("idSach", int.Parse(txt_masach_01.Text)));
                    paramlist.Add(new SqlParameter("mathedocgia", int.Parse(txt_madg_01.Text)));
                    paramlist.Add(new SqlParameter("manhanvien", this.maNhanVien));
                    paramlist.Add(new SqlParameter("ngaymuon", Convert.ToDateTime(datetimengaymuon.Text)));
                    paramlist.Add(new SqlParameter("ngaydukientra", Convert.ToDateTime(dateTimengaytra.Text)));
                    paramlist.Add(new SqlParameter("tinhtrangkhigiao", txt_tinhtrangkhigiao_01.Text));

                    db.Database.ExecuteSqlCommand("exec USP_insertPhieuBanGiao @idSach , @mathedocgia , @manhanvien , @ngaymuon , @ngaydukientra , @tinhtrangkhigiao", paramlist.ToArray());
                    MessageBox.Show("Cho mượn Thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình mượn", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            if (infoStatic.Quyen_ == 1)
            {
                Uc_Menu_Reader uc_Menu_Reader = new Uc_Menu_Reader();
                Add_UserControl.Add_UserControls(uc_Menu_Reader, Pn_Loan);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập tai đây");
            }
        }

        private void ClearForm()
        {
            txt_madg_01.Text = "";
            txt_masach_01.Text = "";
            txt_tinhtrangkhigiao_01.Text = "";
            datetimengaymuon.Value = DateTime.Now;
            dateTimengaytra.Value = DateTime.Now.AddDays(30);

            txt_masach.Text = "";
            txt_madg.Text = "";
            txt_ngaysinh.Text = "";
            txt_diachi.Text = "";
            txt_doituong.Text = "";
            txt_ngaylmthe.Text = "";
            txt_ngaymuon.Text = "";
            txt_tendg.Text = "";
            txt_tentg.Text = "";
            lb_tennv.Text = "";
            txt_sotrang.Text = "";
            txt_trangthaikhigiao.Text = "";
            txt_vaitrotacgia.Text = "";
            txt_tensach.Text = "";
            txt_ngaytra.Text = "";
        }
    }
}