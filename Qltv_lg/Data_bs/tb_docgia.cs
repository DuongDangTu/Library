namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_docgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_docgia()
        {
            tb_bb_nhanlaisach = new HashSet<tb_bb_nhanlaisach>();
            tb_phieubangiaosach = new HashSet<tb_phieubangiaosach>();
        }

        [Key]
        public int mathedocgia { get; set; }

        [Required]
        [StringLength(30)]
        public string hoten { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaysinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaylamthe { get; set; }

        [Required]
        [StringLength(30)]
        public string diachi { get; set; }

        [Required]
        [StringLength(30)]
        public string doituongdocgia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_bb_nhanlaisach> tb_bb_nhanlaisach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_phieubangiaosach> tb_phieubangiaosach { get; set; }
    }
}
