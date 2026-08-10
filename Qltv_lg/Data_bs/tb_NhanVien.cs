namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_NhanVien()
        {
            tb_bb_nhanlaisach = new HashSet<tb_bb_nhanlaisach>();
            tb_Acount = new HashSet<tb_Acount>();
            tb_phieubangiaosach = new HashSet<tb_phieubangiaosach>();
        }

        [Key]
        public int manhanvien { get; set; }

        [Required]
        [StringLength(30)]
        public string tennhanvien { get; set; }

        [Required]
        [StringLength(30)]
        public string taikhoan { get; set; }

        [Required]
        [StringLength(30)]
        public string matKhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_bb_nhanlaisach> tb_bb_nhanlaisach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Acount> tb_Acount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_phieubangiaosach> tb_phieubangiaosach { get; set; }
    }
}
