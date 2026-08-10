namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_sach()
        {
            tb_ct_nhanlai = new HashSet<tb_ct_nhanlai>();
            tb_ct_phieuphat = new HashSet<tb_ct_phieuphat>();
            tb_phieubangiaosach = new HashSet<tb_phieubangiaosach>();
        }

        [Key]
        public int maquyensach { get; set; }

        public int madausach { get; set; }

        public int tinhtrangsach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ct_nhanlai> tb_ct_nhanlai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ct_phieuphat> tb_ct_phieuphat { get; set; }

        public virtual tb_dausach tb_dausach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_phieubangiaosach> tb_phieubangiaosach { get; set; }
    }
}
