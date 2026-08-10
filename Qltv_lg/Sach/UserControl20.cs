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

namespace Qltv_lg.Sach
{
    public partial class User_Control_Menu : UserControl
    {
        Model1 db = new Model1();
        public User_Control_Menu()
        {
            InitializeComponent();
            LoadDataDS();
            LoadComboxTenTacGia();


        }
        void LoadDataDS()
        {
            

            listViewDS.Clear();
            listViewDS.Columns.Add("ID ", 100);
            listViewDS.Columns.Add("Tên Sách", 250);
            listViewDS.Columns.Add("Số Lượng", 150);
            listViewDS.Columns.Add("Số Trang", 150);
            listViewDS.Columns.Add("Tên Tác Giả", 200);
            //var result = db.List1SACH();
            List<SqlParameter> paramlist = new List<SqlParameter>();
            paramlist.Add(new SqlParameter("name", textSearchDS.Text));
            var result = db.Database.SqlQuery<List1SACH_Result>("exec USP_searchDauSach @name", paramlist.ToArray());
            

            foreach (var item in result)
            {
                ListViewItem lsvItem = new ListViewItem(item.madausach.ToString());
                lsvItem.SubItems.Add(item.tendausach.ToString());
                lsvItem.SubItems.Add(item.soluong.ToString());
                lsvItem.SubItems.Add(item.sotrang.ToString());
                lsvItem.SubItems.Add(item.tentacgia.ToString());
                lsvItem.Tag = item.madausach;
               // lsvItem.Tag = item.tendausach;
                this.listViewDS.Items.Add(lsvItem);
            }
        }
        void LoadDataAllQSbyDS()
        {
            try
            {
                int id = int.Parse(txtmasach.Text);
                listViewQS.Clear();
                listViewQS.Columns.Add("mã sách ", 150);
                listViewQS.Columns.Add("Tình Trạng", 150);

                List<SqlParameter> paramlist = new List<SqlParameter>();
                paramlist.Add(new SqlParameter("iddausach", id));
                var result = db.Database.SqlQuery<ListALLQS_Result>("select *from ListALLQS(@iddausach)", paramlist.ToArray());


                foreach (var item in result)
                {
                    ListViewItem lsvItem = new ListViewItem(item.maquyensach.ToString());
                    string tinhtrang = "";
                    if (item.tinhtrangsach == 1)
                    {
                        tinhtrang = "còn sách";
                    }
                    if (item.tinhtrangsach == 2)
                    {
                        tinhtrang = "đã mượn";
                    }
                    if (item.tinhtrangsach == 3)
                    {
                        tinhtrang = "đã mất";
                    }
                    lsvItem.SubItems.Add(tinhtrang);
                    lsvItem.Tag = item.maquyensach;
                    this.listViewQS.Items.Add(lsvItem);
                }



            }
            catch (Exception ex)
            {

            }
        }
        void LoadDataALLTanSuat1QS()
        {
            try
            {
                int id = int.Parse(txtmasach.Text);
                listViewTanSuat.Clear();
                listViewTanSuat.Columns.Add("tên sách", 150);
                listViewTanSuat.Columns.Add("tình trạng ", 100);
                listViewTanSuat.Columns.Add("thống kê", 100);

                List<SqlParameter> paramlist = new List<SqlParameter>();
                paramlist.Add(new SqlParameter("idsach", id));

                //var result1 = db.Database.ExecuteSqlCommand("select [thống kê] from FUN_LietKeTrangThai1DauSach(302)");
                

                var result = db.Database.SqlQuery <FUN_LietKeTrangThai1DauSach_Result>("USP_LietkeTT1DS @idsach", paramlist.ToArray()).ToList();

              
                
          //      var rs = result1.Result; 

                foreach (var item in result)
                {
                    ListViewItem lsvItem = new ListViewItem(item.tendausach.ToString());
                    string tinhtrang = "";
                    if (item.tinhtrangsach == 1)
                    {
                        tinhtrang = "còn sách";
                    }
                    if (item.tinhtrangsach == 2)
                    {
                        tinhtrang = "đã mượn";
                    }
                    if (item.tinhtrangsach == 3)
                    {
                        tinhtrang = "đã mất";
                    }
                    lsvItem.SubItems.Add(tinhtrang);
                    lsvItem.SubItems.Add(item.thongke.ToString());
                    lsvItem.Tag = item.tendausach;
                    this.listViewTanSuat.Items.Add(lsvItem);
                }



            }
            catch (Exception ex)
            {

            }
        }
        void LoadTansuatMuon1DS()
        {

        }

        void LoadComboxTenTacGia()
        {
           // var rs = db.Database.ExecuteSqlCommand("select * from tb_tacgia");
            comboBoxTenTG.DataSource = db.tb_tacgia.ToList();
            comboBoxTenTG.DisplayMember = "tentacgia";
        }
        void newTXT()
        {
            txtmasach.Text = "";
            txtTenSach.Text = "";
            txtsoluong.Text = "0";
            txtsotrang.Text = "0";
            comboBoxTenTG.Text = "Nguyễn Quang Uy";
            comboBoxTenTG.Enabled = true;
            txtsoluong.Enabled = true; 
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            //LoadComboxTenTacGia();
            newTXT();
        }

        private void listViewDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtsoluong.Enabled = false; 
                panel3.Visible = true;
                label14.Visible = true;
                comboBoxTenTG.Enabled = false; 
                listViewQS.Visible = true;

                listViewTanSuat.Visible = true;
                txtmasach.Text = this.listViewDS.SelectedItems[0].SubItems[0].Text;
                txtTenSach.Text = this.listViewDS.SelectedItems[0].SubItems[1].Text;
                txtsoluong.Text = this.listViewDS.SelectedItems[0].SubItems[2].Text;
                txtsotrang.Text = this.listViewDS.SelectedItems[0].SubItems[3].Text;
                comboBoxTenTG.Text = this.listViewDS.SelectedItems[0].SubItems[4].Text;
                btn_Insert.Visible = true;
                btn_Delete_book.Visible = false;
               // btn_Insert.Visible = true;
                //btn_Delete_book.Visible = false;
                LoadDataAllQSbyDS();

                LoadDataALLTanSuat1QS();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listViewDS.SelectedItems[0].SubItems[0].Text);
                //  db.USP_delete1DauSach(id);
                List<SqlParameter> paramlist = new List<SqlParameter>();
                paramlist.Add(new SqlParameter("iddausach",id));
                db.Database.ExecuteSqlCommand("USP_delete1DauSach @iddausach", paramlist.ToArray());
                MessageBox.Show("Xóa Thành Công");
                newTXT();
                LoadDataDS();
                LoadDataAllQSbyDS();
                LoadDataALLTanSuat1QS();

            }
            catch
            {
                MessageBox.Show("ok lỗi rồi ");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tensach = txtTenSach.Text;
            string tentacgia = comboBoxTenTG.Text;
            int soluong = int.Parse(txtsoluong.Text);
            int sotrang = int.Parse(txtsotrang.Text);
            List<SqlParameter> paramlist = new List<SqlParameter>();
            paramlist.Add(new SqlParameter("tentacgia", tentacgia));
            paramlist.Add(new SqlParameter("tendausach", tensach));
            paramlist.Add(new SqlParameter("soluong", soluong));
            paramlist.Add(new SqlParameter("sotrang", sotrang));

            db.Database.ExecuteSqlCommand("exec USP_insert1quyenSach @tentacgia ,@tendausach ,@soluong ,@sotrang", paramlist.ToArray());

            LoadDataDS();
        }

        private void listViewQS_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            try {
                btn_Delete_book.Visible = true;
                btn_Insert.Visible = false;
                btn_Delete_book.Location = new Point(388, 104);

                string strs = this.listViewQS.SelectedItems[0].SubItems[1].Text;
                int id = int.Parse(this.listViewQS.SelectedItems[0].SubItems[0].Text);
                if (strs == "đã mượn")
                {
                    btn_Delete_book.Visible = false;
                    panel6.Visible = true;
                    List<SqlParameter> paramlist = new List<SqlParameter>();
                    paramlist.Add(new SqlParameter("idsach", id));
                    var results = db.Database.SqlQuery<Function_Print1DGtuSach_Result>("select * from Function_Print1DGtuSach(@idsach)", paramlist.ToArray());
                    foreach (var item in results)
                    {
                        textmaDG.Text = item.mathedocgia.ToString();
                        textTenDG.Text = item.hoten.ToString();
                        textNgaySinh.Text = item.ngaysinh.ToString();
                        textNgaylamThe.Text = item.ngaylamthe.ToString();
                        textdoituong.Text = item.doituongdocgia.ToString();
                        textdiachi.Text = item.diachi.ToString();

                    }
                }
                else
                {
                    panel6.Visible = false;
                }

            }
            catch(Exception ex) { }
            
        }

        private void txtmasach_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void User_Control_Menu_Load(object sender, EventArgs e)
        {

        }



        private void Btnsua_Click(object sender, EventArgs e)
        {
           
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("iddausach",int.Parse(txtmasach.Text) ));
            sqlParameters.Add(new SqlParameter("tendausach", txtTenSach.Text));
            sqlParameters.Add(new SqlParameter("tentacgia ", comboBoxTenTG.Text));
            sqlParameters.Add(new SqlParameter("soluong", int.Parse(txtsoluong.Text)));
            sqlParameters.Add(new SqlParameter("sotrang", int.Parse(txtsotrang.Text)));
            db.Database.ExecuteSqlCommand("exec USP_UpdateDauSach @iddausach ,@tendausach , @tentacgia ,@soluong  , @sotrang " , sqlParameters.ToArray());
            LoadDataDS();
            LoadDataAllQSbyDS();
            LoadDataALLTanSuat1QS();
        }

        private void ComboBoxTenTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadComboxTenTacGia();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadDataDS();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtmasach.Text);
            List<SqlParameter> paramlist = new List<SqlParameter>();
            paramlist.Add(new SqlParameter("idmadausach", id));
            db.Database.ExecuteSqlCommand("exec USP_them1QS @idmadausach", paramlist.ToArray());
            //db.USP_them1QS(Convert.ToInt32(txtmasach.Text));
            LoadDataDS();
            LoadDataAllQSbyDS();
            LoadDataALLTanSuat1QS();
        }

        private void btn_Delete_book_Click(object sender, EventArgs e)
        {
            btn_Delete_book.Visible = true;
            btn_Insert.Visible = false;
            btn_Delete_book.Location = new Point(388, 104);
            int masach = Convert.ToInt32(this.listViewQS.SelectedItems[0].SubItems[0].Text);
            List<SqlParameter> paramlist = new List<SqlParameter>();
            paramlist.Add(new SqlParameter("idsach", masach));
            db.Database.ExecuteSqlCommand("exec USP_Delete1QuyenSach @idsach", paramlist.ToArray());
            // db.USP_Delete1QuyenSach(Convert.ToInt32(masach));
            LoadDataDS();
            LoadDataAllQSbyDS();
            LoadDataALLTanSuat1QS();
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }catch(Exception ex ) { }
        }

        private void txtsotrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }catch(Exception ex )
            {

            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
/*            if (Convert.ToInt32(txtsoluong.Text) < 0)
            {
                MessageBox.Show("invalid");
            }*/
        }

        private void txtsotrang_TextChanged(object sender, EventArgs e)
        {
/*            if (Convert.ToInt32(txtsoluong.Text) < 0)
            {
                MessageBox.Show("invalid");
            }*/
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textSearchDS_Enter(object sender, EventArgs e)
        {
            if (textSearchDS.Text == "Search")
            {
                textSearchDS.Text = "";
                textSearchDS.ForeColor = Color.Black;
            }
        }
    }
}
