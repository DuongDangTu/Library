using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qltv_lg.Data_bs
{
    using System;

    public partial class USP_PrintPhieuBanGiao_Result
    {
        public int mathedocgia { get; set; }
        public string hoten { get; set; }
        public System.DateTime ngaysinh { get; set; }
        public System.DateTime ngaylamthe { get; set; }
        public string diachi { get; set; }
        public string doituongdocgia { get; set; }
        public string tennhanvien { get; set; }
        public int maquyensach { get; set; }
        public int madausach { get; set; }
        public string tendausach { get; set; }
        public int soluong { get; set; }
        public int sotrang { get; set; }

        public Nullable<int> tansuat { get; set; }

        public string tentacgia { get; set; }
        public Nullable<System.DateTime> ngaydukientra { get; set; }
        public Nullable<System.DateTime> ngaymuon { get; set; }
        public string tinhtrangkhigiao { get; set; }
    }
}
