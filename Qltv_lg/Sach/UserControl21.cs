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
    public partial class UserControl21 : UserControl
    {
        public UserControl21()
        {
            InitializeComponent();
        }
        public int idNV { get; set; }

        private void radio_User_CheckedChanged(object sender, EventArgs e)
        {
            this.idNV = 1; 
        }

        private void radio_Admin_CheckedChanged(object sender, EventArgs e)
        {
            this.idNV = 1;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
