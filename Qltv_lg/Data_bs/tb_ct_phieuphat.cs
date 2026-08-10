namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_ct_phieuphat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maphieuphat { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maquyensach { get; set; }

        public int songayquahan { get; set; }

        [Required]
        [StringLength(30)]
        public string tinhtranghong { get; set; }

        public virtual tb_phieuphat tb_phieuphat { get; set; }

        public virtual tb_sach tb_sach { get; set; }
    }
}
