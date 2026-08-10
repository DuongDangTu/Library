using DevExpress.XtraEditors;
using Qltv_lg.SqlServerTypes;
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
    public partial class Frm_Main : DevExpress.XtraEditors.XtraForm
    {
        //XtraForm1 FrXtra = new XtraForm1();
        
        public Frm_Main()
        {
            //Frm_Main FrXtra = new Frm_Main();
            InitializeComponent();
            /* UcUser_Managerment ucUser = new UcUser_Managerment();
             Add_UserControl(ucUser);*/
            // FrXtra.Size =new Size(1258, 655); 
            //Form_Main.Size = new Size(1258, 655);
            // this.Size = new Size(1258, 655);
            // MessageBox.Show(Size.ToString());
            UcHomePage home = new UcHomePage();
            Add_UserControl(home);
        }
        public void Add_UserControl ( Control control)
        {

            Pn_Main.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();

            control.Focus();
            Pn_Main.Controls.Add(control);
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //btn_Exit
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","Cảnh Báo" , MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }    
        }
        private void Click_bt_HomePage(object sender, EventArgs e)
        {
            Lb_DashBorad.Visible = true;
            btn_M.Visible = false;
            btn_B.Visible = false;
            btn_L.Visible = false;
            btn_Re.Visible = false;
            btn_S.Visible = false;
            btn_R.Visible = false;
            // MessageBox.Show(Pn_Main.Size.ToString());
            /* if (!Pn_Main.Controls.Contains(HomePage.Instance))
             {
                 Pn_Main.Controls.Add(HomePage.Instance);
                 HomePage.Instance.Dock = DockStyle.Fill;
                 HomePage.Instance.BringToFront();
             }
             else
                 HomePage.Instance.BringToFront(); */
          
            UcHomePage home = new UcHomePage();
            Add_UserControl(home);
        }
        UcUser_Managerment ucUser = new UcUser_Managerment();
        private void btn_Click_UserManggerment(object sender, EventArgs e)
        {
            if (infoStatic.Quyen_ == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập tai đây");
            }
            else if (infoStatic.Quyen_ == 1)
            {
                // MessageBox.Show(infoStatic.txtUser);
                Lb_DashBorad.Visible = false;
                btn_M.Visible = true;
                btn_B.Visible = false;
                btn_L.Visible = false;
                btn_Re.Visible = false;
                btn_S.Visible = false;
                btn_R.Visible = false;
                /* if (!Pn_Main.Controls.Contains(UcUser_Managerment.Instance))
                 {
                     Pn_Main.Controls.Add(UcUser_Managerment.Instance);
                     UcUser_Managerment.Instance.Dock = DockStyle.Fill;
                     UcUser_Managerment.Instance.BringToFront();
                 }
                 else
                     UcUser_Managerment.Instance.BringToFront();*/

                Add_UserControl(ucUser);
        }
            else
            {
                MessageBox.Show("9 điểm cô ơi");
            }

}

        private void btn_Click_BookManagerment(object sender, EventArgs e)
        {
            if (infoStatic.Quyen_ == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập tai đây");
            }
            else if (infoStatic.Quyen_ == 1)
            {
                Lb_DashBorad.Visible = false;
                btn_M.Visible = false;
                btn_B.Visible = true;
                btn_L.Visible = false;
                btn_Re.Visible = false;
                btn_S.Visible = false;
                btn_R.Visible = false;
                /* Book_Managerment book = new Book_Managerment();
                 Pn_Main.Visible = false;
                 book.Location = new Point(202, 97);
                 book.Visible = true; */

                //if (!Pn_Main.Controls.Contains(Book_Managerment.Instance))
                //{
                //    Pn_Main.Controls.Add(Book_Managerment.Instance);
                //    Book_Managerment.Instance.Dock = DockStyle.Fill;
                //    Book_Managerment.Instance.Size = new Size(1058, 554);
                //    Book_Managerment.Instance.BringToFront();
                //}
                //else
                //    Book_Managerment.Instance.BringToFront();
                User_Control_Menu user_Control_Menu = new User_Control_Menu();
                Add_UserControl(user_Control_Menu);
            }
            else
            {
                MessageBox.Show("9 điểm cô ơi");
            }
        }

        

        private void btn_Click_ReadersManagerment(object sender, EventArgs e)
        {
            Lb_DashBorad.Visible = false;
            btn_M.Visible = false;
            btn_B.Visible = false;
            btn_L.Visible = false;
            btn_Re.Visible = true;
            btn_S.Visible = false;
            btn_R.Visible = false;
            /* if (!Pn_Main.Controls.Contains(Readers_Managerment.Instance))
             {
                 Pn_Main.Controls.Add(Readers_Managerment.Instance);
                 Readers_Managerment.Instance.Dock = DockStyle.Fill;
                 Readers_Managerment.Instance.BringToFront();

             }
             else
                 Readers_Managerment.Instance.BringToFront();*/
            UcReaders_Managerment ucReaders = new UcReaders_Managerment();
            Add_UserControl(ucReaders);
        }

        private void btn_Click_Loan(object sender, EventArgs e)
        {
            Lb_DashBorad.Visible = false;
            btn_M.Visible = false;
            btn_B.Visible = false;
            btn_L.Visible = true;
            btn_Re.Visible = false;
            btn_S.Visible = false;
            btn_R.Visible = false;
            /*  if (!Pn_Main.Controls.Contains(Loan_Managerment.Instance))
              {
                  Pn_Main.Controls.Add(Loan_Managerment.Instance);
                  Loan_Managerment.Instance.Dock = DockStyle.Fill;
                  Loan_Managerment.Instance.BringToFront();
              }
              else
                  Loan_Managerment.Instance.BringToFront();*/
            UcLoan_Managerment ucLoan = new UcLoan_Managerment();
            Add_UserControl(ucLoan); 
        }

        private void btn_Click_Return(object sender, EventArgs e)
        {
            Lb_DashBorad.Visible = false;
            btn_M.Visible = false;
            btn_B.Visible = false;
            btn_L.Visible = false;
            btn_Re.Visible = false;
            btn_S.Visible = false;
            btn_R.Visible = true;
            /*   if (!Pn_Main.Controls.Contains(Return_Managerment.Instance))
               {
                   Pn_Main.Controls.Add(Return_Managerment.Instance);
                   Return_Managerment.Instance.Dock = DockStyle.Fill;
                   Return_Managerment.Instance.BringToFront();
               }
               else
                   Return_Managerment.Instance.BringToFront();*/
            UcReturn_Managerment ucReturn = new UcReturn_Managerment();
            Add_UserControl(ucReturn);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            // timerYellow.Start();
            //Frm_Main frm_Main = new Frm_Main();
            // MessageBox.Show(frm_Main.Size.ToString());
         /*   if(ucUser.getQuyen()== "User")
            {
                btn_BookManagerment.Visible = false;
                btn_UseerManagerment.Visible = false;
                button7.Visible = false; 
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

            if (infoStatic.Quyen_ == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập tai đây");
            }
            else if (infoStatic.Quyen_ == 1)
            {
                Lb_DashBorad.Visible = false;
                btn_M.Visible = false;
                btn_B.Visible = false;
                btn_L.Visible = false;
                btn_Re.Visible = false;
                btn_S.Visible = true;
                btn_R.Visible = false;
                UcBook_Managerment ucBook_Managerment = new UcBook_Managerment();
                Add_UserControl(ucBook_Managerment);
            }
            else
            {
                MessageBox.Show("9 điểm cô ơi");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void timerYellow_Tick(object sender, EventArgs e)
        {
           // picture_anmated.Left += 1; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}