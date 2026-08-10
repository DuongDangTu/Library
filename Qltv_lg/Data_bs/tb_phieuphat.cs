namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_phieuphat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_phieuphat()
        {
            tb_ct_phieuphat = new HashSet<tb_ct_phieuphat>();
        }

        [Key]
        public int maphieuphat { get; set; }

        public int mabbnhanlai { get; set; }

        public int? tongtien { get; set; }

        public virtual tb_bb_nhanlaisach tb_bb_nhanlaisach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ct_phieuphat> tb_ct_phieuphat { get; set; }
    }
}
