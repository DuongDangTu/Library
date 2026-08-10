namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_ct_nhanlai
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mabbnhanlai { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maquyensach { get; set; }

        [Required]
        [StringLength(30)]
        public string tinhtrangnhanlai { get; set; }

        public virtual tb_bb_nhanlaisach tb_bb_nhanlaisach { get; set; }

        public virtual tb_sach tb_sach { get; set; }
    }
}
