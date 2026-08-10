namespace Qltv_lg.Data_bs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Acount
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Gmail { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int manhanVien { get; set; }

        public virtual tb_NhanVien tb_NhanVien { get; set; }
    }
}
