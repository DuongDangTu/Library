namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_dausach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_dausach()
        {
            tb_ct_tacgia = new HashSet<tb_ct_tacgia>();
            tb_sach = new HashSet<tb_sach>();
        }

        [Key]
        public int madausach { get; set; }

        [Required]
        [StringLength(30)]
        public string tendausach { get; set; }

        public int soluong { get; set; }

        public int sotrang { get; set; }

        public int? tansuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ct_tacgia> tb_ct_tacgia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_sach> tb_sach { get; set; }
    }
}
