namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_tacgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_tacgia()
        {
            tb_ct_tacgia = new HashSet<tb_ct_tacgia>();
        }

        [Key]
        public int matacgia { get; set; }

        [Required]
        [StringLength(30)]
        public string tentacgia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ct_tacgia> tb_ct_tacgia { get; set; }
    }
}
