using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
using DevExpress.XtraEditors;
using System.Net;
using System.IO;
using Qltv_lg.Sach;
using Qltv_lg.SqlServerTypes;
using System.Data.SqlClient;
using Qltv_lg.Data_bs;

namespace Qltv_lg
{
    public partial class Fm_Login : DevExpress.XtraEditors.XtraForm
    {
        Model1 db = new Model1();
        Frm_Main FrQL = new Frm_Main();
        //Fm_Login fm = new Fm_Login();
        //Form_Quyen fm = new Form_Quyen();
        // us = new UserControl21();
        public Fm_Login()
        {
            InitializeComponent();
            this.AcceptButton = bt_Login;
            timer1.Start();

        }

        private void Img_Account_Click(object sender, EventArgs e)
        {

        }

        private void Img_Password_Click(object sender, EventArgs e)
        {

        }
        #region làm chữ chạy màu
        int ChangeColor = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ChangeColor == 0)
            {
                lb_Content.ForeColor = Color.Aqua;
                ChangeColor = 1;
            }
            else
            {
                lb_Content.ForeColor = Color.Yellow;
                ChangeColor = 0;
            }
        }
        #endregion

        private void Fm_Login_Load(object sender, EventArgs e)
        {
            WinApi.AnimateWindow(this.Handle, 500, 0X1);//Animation
        }

        private void FormLg_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #region WaterMark
        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
            {
                txt_UserName.Text = "Username";
                txt_UserName.ForeColor = Color.Gray;
            }
        }
        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "Username")
            {
                txt_UserName.Text = "";
                txt_UserName.ForeColor = Color.Black;
            }
        }


        private void txt_PassWord_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
                txt_Password.ForeColor = Color.Gray;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.Black;
                txt_Password.PasswordChar = '*';
            }
        }
        #endregion
        #region show pass
        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (Ck_ShowPassword.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }


        #endregion

        #region WateMark thay đổi mật khẩu

        private void txt_UsernameSg_Leave(object sender, EventArgs e)
        {
            if (text_UsernameSg.Text == "")
            {
                text_UsernameSg.Text = "Username";
                text_UsernameSg.ForeColor = Color.Gray;
            }
        }

        private void txt_UsernameSg_Enter(object sender, EventArgs e)
        {
            if (text_UsernameSg.Text == "Username")
            {
                text_UsernameSg.Text = "";
                text_UsernameSg.ForeColor = Color.Black;

            }
        }

        private void txt_PasswordSg_Leave(object sender, EventArgs e)
        {
            if (text_PassWordSg.Text == "")
            {
                text_PassWordSg.Text = "Password Old";
                text_PassWordSg.ForeColor = Color.Gray;
            }
        }

        private void txt_PasswordSg_Enter(object sender, EventArgs e)
        {
            if (text_PassWordSg.Text == "Password Old")
            {
                text_PassWordSg.Text = "";
                text_PassWordSg.ForeColor = Color.Black;
                text_PassWordSg.PasswordChar = '*';
            }
        }

        private void txt_Re_EnterPassword_Leave(object sender, EventArgs e)
        {
            if (txt_Re_EnterPassWord.Text == "")
            {
                txt_Re_EnterPassWord.Text = "Password New";
                txt_Re_EnterPassWord.ForeColor = Color.Gray;
            }
        }

        private void txt_Re_EnterPassword_Enter(object sender, EventArgs e)
        {
            if (txt_Re_EnterPassWord.Text == "Password New")
            {
                txt_Re_EnterPassWord.Text = "";
                txt_Re_EnterPassWord.ForeColor = Color.Black;
                txt_Re_EnterPassWord.PasswordChar = '*';
            }
        }

        #endregion

        #region Create Account
        private void Lb_CreatAccount_Click(object sender, EventArgs e)
        {
            Pn_Sign.Visible = true;
            Pn_Login.Visible = false;
            Pn_Sign.Location = new Point(218, 98);
            //Pn_Sign.Size = new Size(502, 465);
            this.AcceptButton = bt_Sigin;
        }
        #endregion

        #region Return Login

        private void Bt_BackLogin_Click(object sender, EventArgs e)
        {
            Pn_Sign.Visible = false;
            Pn_Login.Visible = true;
            this.AcceptButton = bt_Login;
        }

        #endregion


        #region Show Pass in form change pass
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPasswordold_new.Checked == true)
            {
                text_PassWordSg.UseSystemPasswordChar = true;
                txt_Re_EnterPassWord.UseSystemPasswordChar = true;
            }
            else
            {
                text_PassWordSg.UseSystemPasswordChar = false;
                txt_Re_EnterPassWord.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region Connection with Webservice
        private void bt_Login_Click(object sender, EventArgs e)
        {
           // Fm_Login fm = new Fm_Login();
            infoStatic.txtUser = txt_UserName.Text;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("gmail", txt_UserName.Text));
            var tb = db.Database.SqlQuery<TaiKhoan_Result>("select * from TaiKhoan(@gmail)", sqlParameters.ToArray()).ToList();
            foreach(var item in tb)
            {
                if(item.Gmail == txt_UserName.Text && item.Password == txt_Password.Text)
                {
                    infoStatic.Quyen_ = Convert.ToInt32(item.quyen.ToString());
                    MessageBox.Show("Logged in successfully");
                    this.Hide();
                    FrQL.ShowDialog();
                    
                    break;
                }
                MessageBox.Show("You have failed to login");
            }
            this.Hide();
        }
        #endregion
        /* public string getgmail()
         {
             return txt_UserName.Text;
         }*/
        private void svgImageBox4_Click(object sender, EventArgs e)
        {

        }

        private void bt_Sigin_Click(object sender, EventArgs e)
        {

                    if (text_PassWordSg.Text.Length - 1 < 5)
                    {
                        MessageBox.Show("the new password is too Short");
                        
                    }
                    else if (text_PassWordSg.Text.Length - 1 > 30)
                    {
                        MessageBox.Show("the new password is too long");
                        
                    }
                    else if (text_PassWordSg.Text != txt_Re_EnterPassWord.Text)
                    {
                        MessageBox.Show("password incorrect");
                     
                    }
                    else
                    {
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("mail", text_UsernameSg.Text));
                sqlParameters.Add(new SqlParameter("pass", text_PassWordSg.Text));
                sqlParameters.Add(new SqlParameter("name", txt_Name.Text));
                if (radioButton1.Checked == true)
                {
                    sqlParameters.Add(new SqlParameter("quyen","0"));
                }
                else if (radioButton2.Checked == true)
                {
                    sqlParameters.Add(new SqlParameter("quyen","1"));
                }
                db.Database.ExecuteSqlCommand("exec DKTaiKhoan @mail , @pass  , @name , @quyen", sqlParameters.ToArray());
                MessageBox.Show("Successful registration");
                    
                    }
            
        }
        private string WebApiPostMethod(string postData , string url)
        {
            string ReponseFormServer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("url");
            request.Method = "POST";


            request.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            ReponseFormServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return ReponseFormServer; 
        }
        private void PostDataJson(string username, string password)
        {
            String url = "https://localhost:44352/api/WebApis/Get?username=" + username + "&password=" + password;
            WebApiPostMethod("s", url);
        }

        private void Pn_Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_UsernameSg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_Enter(object sender, EventArgs e)
        {
            if (txt_Name.Text == "Name")
            {
                txt_Name.Text = "";
                txt_Name.ForeColor = Color.Black;
               
            }
        }

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                txt_Name.Text = "Name";
                txt_Name.ForeColor = Color.Gray;
            }
        }
    }
}
