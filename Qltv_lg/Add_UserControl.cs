using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qltv_lg
{
    class Add_UserControl
    {
        public static void Add_UserControls(System.Windows.Forms.Control control , System.Windows.Forms.Control Pn_Main )
        {
            Pn_Main.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Pn_Main.Controls.Add(control);

        }
    }
}
