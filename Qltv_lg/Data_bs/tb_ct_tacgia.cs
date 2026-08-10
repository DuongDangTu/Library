namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_ct_tacgia
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int matacgia { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int madausach { get; set; }

        [Required]
        [StringLength(30)]
        public string vaitrotacgia { get; set; }

        public virtual tb_dausach tb_dausach { get; set; }

        public virtual tb_tacgia tb_tacgia { get; set; }
    }
}
