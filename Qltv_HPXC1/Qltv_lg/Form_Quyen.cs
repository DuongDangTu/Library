using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qltv_lg
{
    public partial class Form_Quyen : Form
    {
        //Form_Quyen fm;
        public int idNV { get; set; }
        public Form_Quyen()
        {
            InitializeComponent();
           // fm = new Form_Quyen();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_Admin.Checked == true)
            {
                idNV = 1;
            }
            else
            {
                idNV = 0;
            }
            //Application.Exit();
        }
        public bool getvalueRadioAdmin()
        {
           
            return  radio_Admin.Checked; 
        }
        public bool getvalueRadioUser()
        {
           
            return radio_User.Checked; 
        }

        private void radio_User_CheckedChanged(object sender, EventArgs e)
        {
           if(radio_User.Checked == true)
            {
                idNV = 0; 
            }
            else
            {
                idNV = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_Quyen_Load(object sender, EventArgs e)
        {

        }
    }
}
