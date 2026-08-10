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
    public partial class UcReturn_Managerment : UserControl
    {
        Model1 db = new Model1();
        private int masach;
        private int maNhanVien;
        public UcReturn_Managerment()
        {
            InitializeComponent();
        }
        void LoadDataComboxTenSach()
        {
            try
            {
                this.masach = int.Parse(txt_madgpay.Text);
                List<SqlParameter> paramlist = new List<SqlParameter>();
                paramlist.Add(new SqlParameter("iddocgia", this.masach));
                
                var result = db.Database.SqlQuery<USP_sachmuon1DocGia_Result>("exec USP_sachmuon1DocGia @iddocgia",paramlist.ToArray());
                comboBox_masach.DataSource = result.ToList();
                comboBox_masach.DisplayMember = "maquyensach";
            }
            catch (Exception ex) { }
        }
        private void UserControl9_Load(object sender, EventArgs e)
        {

        }


        private void comboBox_masach_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.masach = int.Parse(comboBox_masach.Text);

        }

        private void txt_madgpay_TextChanged(object sender, EventArgs e)
        {
            LoadDataComboxTenSach();
        }

        private void btn_muon_Click(object sender, EventArgs e)
        {
            if (txt_madgpay.Text == "" || comboBox_masach.Text == "")
            {
                MessageBox.Show("nhập đầy đủ thông tin vào", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.maNhanVien = 100;
                List<SqlParameter> paramlist = new List<SqlParameter>();
                paramlist.Add(new SqlParameter("ngaytra", (Convert.ToDateTime(dateTimePay.Text))));
                paramlist.Add(new SqlParameter("mathedocgia", int.Parse(txt_madgpay.Text)));
                paramlist.Add(new SqlParameter("manhanvien", this.maNhanVien));
                paramlist.Add(new SqlParameter("idSach", int.Parse(comboBox_masach.Text)));
                //db.USP_traSach(Convert.ToDateTime(dateTimePay.Text), int.Parse(txt_madgpay.Text), 100, int.Parse(comboBox_masach.Text));
                panel4.Visible = true;
                btn_report.Enabled = true;
                panel3.Visible = false;
                panel6.Visible = false;
                db.Database.ExecuteSqlCommand("exec USP_traSach @ngaytra , @mathedocgia ,@manhanvien , @idSach", paramlist.ToArray());
                MessageBox.Show("Trả sách thành công");

                int id =this.masach;// this.masach;

                List<SqlParameter> paramlist1 = new List<SqlParameter>();
                paramlist1.Add(new SqlParameter("idSach",id));
                var rs = db.Database.SqlQuery<Nullable<int>>("exec USP_PrintPhieuTrasachtest1 @idSach", paramlist1.ToArray()).ToList();
                var s = rs[0];
                if (s == 0)
                {
                    
                    List<SqlParameter> paramlist2 = new List<SqlParameter>();
                    paramlist2.Add(new SqlParameter("idSach", id));
                    var sr1 =  db.Database.SqlQuery<Function_PhieuTraNoBiPhat_Result>("select * from Function_PhieuTraNoBiPhat(@idSach)", paramlist2.ToArray());
                    //var sr1 = db.Function_PhieuTraNoBiPhat(id).ToList();
                    foreach (var r in sr1)
                    {
                        txt_tendgpay.Text = r.hoten.ToString();
                        txt_ngsinh.Text = r.ngaysinh.ToString();
                        txt_nglmthe.Text = r.ngaylamthe.ToString();
                        txt_madg.Text = r.mathedocgia.ToString();
                        txt_doituong.Text = r.doituongdocgia.ToString();
                        txtrstensach.Text = r.madausach.ToString();
                        txt_tsach.Text = r.tendausach.ToString();
                        txt_msach.Text = r.madausach.ToString();
                        txt_tgia.Text = r.tentacgia.ToString();
                        txt_sotrang.Text = r.sotrang.ToString();
                        txt_ttrangsach.Text = r.tinhtrangnhanlai.ToString();
                        txt_ngtra.Text = r.ngaytra.ToString();
                        txt_songquahan.Text = "không";
                        txt_ttien.Text = "0";
                    }
                }
                if (s == 1)
                {
                    List<SqlParameter> paramlist3 = new List<SqlParameter>();
                    paramlist3.Add(new SqlParameter("idSach", id));
                    panel6.Visible = true;
                    panel3.Visible = true;
                    btn_report.Enabled = true;
                    var rs2 = db.Database.SqlQuery<Function_PhieuTraBiPhat_Result>("select * from Function_PhieuTraBiPhat(@idSach)", paramlist3.ToArray()).ToList();
                    foreach (var r in rs2)
                    {
                        txtrsTendg1.Text = r.hoten.ToString();
                        txtrstensach.Text = r.tendausach.ToString();
                        txtrssongayquahan1.Text = r.songayquahan.ToString();
                        txtrstongsotien1.Text = r.tongtien.ToString() + "VNĐ";
                        txtrstinhtrangkhigiao.Text = r.tinhtranghong.ToString();
                        txtrstentg.Text = r.tentacgia.ToString();
                        txtrsngaysinh1.Text = r.ngaysinh.ToString();
                        txtrsngaylt1.Text = r.ngaylamthe.ToString();
                        txtrsstramg.Text = r.sotrang.ToString();
                        txtrsngaytra1.Text = dateTimePay.Text;
                        txtrsdoituong.Text = r.doituongdocgia.ToString();
                        txtrsmadocgia1.Text = r.mathedocgia.ToString();
                        txtrsmasach.Text = r.maquyensach.ToString();


                        txt_tendgpay.Text = r.hoten.ToString();
                        txt_ngsinh.Text = r.ngaysinh.ToString();
                        txt_nglmthe.Text = r.ngaylamthe.ToString();
                        txt_madg.Text = r.mathedocgia.ToString();
                        txt_doituong.Text = r.doituongdocgia.ToString();
                        txt_tsach.Text = r.tendausach.ToString();
                        txt_msach.Text = r.tendausach.ToString();
                        txt_tgia.Text = r.tentacgia.ToString();
                        txt_sotrang.Text = r.sotrang.ToString();
                        txt_ttrangsach.Text = txtrstinhtrangkhigiao.Text;
                        txt_ngtra.Text = r.ngaytra.ToString();
                        txt_songquahan.Text = r.songayquahan.ToString();
                        txt_ttien.Text = txtrstongsotien1.Text;
                    }
                }
            }
        }
        // mất sachh
        private void btn_New_Click(object sender, EventArgs e)
        {
            if (txt_madgpay.Text == "" || comboBox_masach.Text == "")
            {
                MessageBox.Show("nhập đầy đủ thông tin vào", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int sotiendefault = 500000;
                this.maNhanVien = 100;
                List<SqlParameter> paramlist = new List<SqlParameter>();
                paramlist.Add(new SqlParameter("ngaytra", (Convert.ToDateTime(dateTimePay.Text))));
                paramlist.Add(new SqlParameter("mathedocgia", int.Parse(txt_madgpay.Text)));
                paramlist.Add(new SqlParameter("manhanvien", this.maNhanVien));
                paramlist.Add(new SqlParameter("idSach", int.Parse(comboBox_masach.Text)));
                paramlist.Add(new SqlParameter("sotienphat",sotiendefault));
                //db.USP_traSach(Convert.ToDateTime(dateTimePay.Text), int.Parse(txt_madgpay.Text), 100, int.Parse(comboBox_masach.Text));
                panel4.Visible = true;
                db.Database.ExecuteSqlCommand("exec USP_matsach @ngaytra , @mathedocgia ,@manhanvien , @idSach ,@sotienphat", paramlist.ToArray());
                MessageBox.Show("Bồi Thường thiệt Hại thành công");
                int id = this.masach;// this.masach;
                    List<SqlParameter> paramlist3 = new List<SqlParameter>();
                    paramlist3.Add(new SqlParameter("idSach", id));
                    panel6.Visible = true;
                    panel3.Visible = true;
                    btn_report.Enabled = true; 
                    var rs2 = db.Database.SqlQuery<Function_PhieuTraBiPhat_Result>("select * from Function_PhieuTraBiPhat(@idSach)", paramlist3.ToArray()).ToList();
                    foreach (var r in rs2)
                    {
                        txtrsTendg1.Text = r.hoten.ToString();
                        txtrstensach.Text = r.tendausach.ToString();
                        txtrssongayquahan1.Text = r.songayquahan.ToString();
                        txtrstongsotien1.Text = r.tongtien.ToString() + "VNĐ";
                        txtrstinhtrangkhigiao.Text = r.tinhtranghong.ToString();
                        txtrstentg.Text = r.tentacgia.ToString();
                        txtrsngaysinh1.Text = r.ngaysinh.ToString();
                        txtrsngaylt1.Text = r.ngaylamthe.ToString();
                        txtrsstramg.Text = r.sotrang.ToString();
                        txtrsngaytra1.Text = r.ngaytra.ToString();
                        txtrsdoituong.Text = r.doituongdocgia.ToString();
                        txtrsmadocgia1.Text = r.mathedocgia.ToString();
                        txtrsmasach.Text = r.maquyensach.ToString();


                        txt_tendgpay.Text = r.hoten.ToString();
                        txt_ngsinh.Text = r.ngaysinh.ToString();
                        txt_nglmthe.Text = r.ngaylamthe.ToString();
                        txt_madg.Text = r.mathedocgia.ToString();
                        txt_doituong.Text = r.doituongdocgia.ToString();
                        txt_tsach.Text = r.tendausach.ToString();
                        txt_msach.Text = r.madausach.ToString();
                        txt_tgia.Text = r.tentacgia.ToString();
                        txt_sotrang.Text = r.sotrang.ToString();
                        txt_ttrangsach.Text = txtrstinhtrangkhigiao.Text;
                        txt_ngtra.Text = r.ngaytra.ToString();
                        txt_songquahan.Text = r.songayquahan.ToString();
                        txt_ttien.Text = txtrstongsotien1.Text;
                    
                }
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            //if(panel4.Visible == true)
            //{
            //    List<SqlParameter> sqlParameters = new List<SqlParameter>();
            //    sqlParameters.Add(new SqlParameter("iddocgia", int.Parse(txt_madg.Text)));
            //    sqlParameters.Add(new SqlParameter("ngmuon", Convert.ToDateTime(dateTimePay.Text)));
            //    var result = db.Database.SqlQuery<Report_tra_Result>("select * from Report_tra(@iddocgia , @ngmuon)", sqlParameters.ToArray()).ToArray();
            //    CrystalReport2 crystalReport2 = new CrystalReport2();
            //    crystalReport2.SetDataSource(result);
            //    Form_RpMuonSach fm = new Form_RpMuonSach();
            //    fm.crystalReportViewer1.ReportSource = crystalReport2;
            //    fm.ShowDialog();

            //}
            if (infoStatic.Quyen_ == 1)
            {
                if (panel4.Visible == true && panel3.Visible == true)
                {
                    List<SqlParameter> sqlParameters = new List<SqlParameter>();
                    sqlParameters.Add(new SqlParameter("iddocgia", int.Parse(txt_madg.Text)));
                    sqlParameters.Add(new SqlParameter("ngmuon", Convert.ToDateTime(dateTimePay.Text)));
                    var result = db.Database.SqlQuery<Report_phat_Result>("select * from Report_phat(@iddocgia , @ngmuon)", sqlParameters.ToArray()).ToList();
                    CrystalReport4 crystalReport4 = new CrystalReport4();
                    crystalReport4.SetDataSource(result);
                    Form_RpMuonSach fm = new Form_RpMuonSach();
                    fm.crystalReportViewer1.ReportSource = crystalReport4;
                    fm.ShowDialog();
                }
                else if (panel4.Visible == true)
                {
                    List<SqlParameter> sqlParameters = new List<SqlParameter>();
                    sqlParameters.Add(new SqlParameter("iddocgia", int.Parse(txt_madg.Text)));
                    sqlParameters.Add(new SqlParameter("ngmuon", Convert.ToDateTime(dateTimePay.Text)));
                    var result = db.Database.SqlQuery<Report_tra_Result>("select * from Report_tra(@iddocgia , @ngmuon)", sqlParameters.ToArray()).ToArray();
                    CrystalReport2 crystalReport2 = new CrystalReport2();
                    crystalReport2.SetDataSource(result);
                    Form_RpMuonSach fm = new Form_RpMuonSach();
                    fm.crystalReportViewer1.ReportSource = crystalReport2;
                    fm.ShowDialog();

                }
            }
            else if(infoStatic.Quyen_ == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập tai đây");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
