namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_phieubangiaosach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_phieubangiaosach()
        {
            tb_sach = new HashSet<tb_sach>();
        }

        [Key]
        public int maphieubangiao { get; set; }

        public int mathedocgia { get; set; }

        public int manhanvien { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaymuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaydukientra { get; set; }

        [Required]
        [StringLength(30)]
        public string tinhtrangkhigiao { get; set; }

        public virtual tb_docgia tb_docgia { get; set; }

        public virtual tb_NhanVien tb_NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_sach> tb_sach { get; set; }
    }
}
