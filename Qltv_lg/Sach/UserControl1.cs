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
    public partial class UcUser_Managerment : UserControl
    {
        Model1 db = new Model1();
        //Form_Quyen fm = new Form_Quyen();
        //Fm_Login fl = new Fm_Login();
        public UcUser_Managerment()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        //Fm_Login fl = new Fm_Login();
        void LoadData()
        {
            //UserControl21 us = new UserControl21();
            Form_Quyen fm = new Form_Quyen();
            //Fm_Login fl = new Fm_Login();
            // List<SqlParameter> sqlParameters = new List<SqlParameter>();
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("gmail", infoStatic.txtUser));
            var result = db.Database.SqlQuery<TaiKhoan_Result>("select * from TaiKhoan(@gmail)",sqlParameters.ToArray()).ToList();
            foreach (var item in result)
            {
                lb_ID.Text = item.manhanvien.ToString();
                lb_Employee.Text = item.tennhanvien.ToString();
                lb_gmail.Text = item.Gmail.ToString();
                lb_Password.Text = item.Password.ToString();
                if (item.quyen == 1)
                {
                    lb_quyen.Text = "Admin";
                }else if(item.quyen == 0)
                {
                    lb_quyen.Text = "User";
                }
                infoStatic.txtUser = lb_quyen.Text; 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Fm_Login FrLg = new Fm_Login();
            FrLg.ShowDialog();
        }
    }
}
