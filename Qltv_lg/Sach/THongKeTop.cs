using Qltv_lg.Data_bs;
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
    public partial class THongKeTop : Form
    {
        public THongKeTop()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();
        void HienThiTHongKeTop()
        {
            var rs = db.Database.SqlQuery<tb_dausach>("select top 10 * from tb_dausach order by tansuat DESC ");
            tbdausachBindingSource.DataSource = rs.ToList();
        }
        private void THongKeTop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVMATTERByHPXCDataSet.tb_dausach' table. You can move, or remove it, as needed.
            this.tb_dausachTableAdapter.Fill(this.qLTVMATTERByHPXCDataSet.tb_dausach);
            HienThiTHongKeTop();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
