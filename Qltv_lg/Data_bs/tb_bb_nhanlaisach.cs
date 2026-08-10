namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_bb_nhanlaisach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_bb_nhanlaisach()
        {
            tb_ct_nhanlai = new HashSet<tb_ct_nhanlai>();
            tb_phieuphat = new HashSet<tb_phieuphat>();
        }

        [Key]
        public int mabbnhanlai { get; set; }

        public int mathedocgia { get; set; }

        public int manhanvien { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaytra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ct_nhanlai> tb_ct_nhanlai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_phieuphat> tb_phieuphat { get; set; }

        public virtual tb_docgia tb_docgia { get; set; }

        public virtual tb_NhanVien tb_NhanVien { get; set; }
    }
}
