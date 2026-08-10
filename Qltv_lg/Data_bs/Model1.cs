using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Qltv_lg.Data_bs
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tb_bb_nhanlaisach> tb_bb_nhanlaisach { get; set; }
        public virtual DbSet<tb_ct_nhanlai> tb_ct_nhanlai { get; set; }
        public virtual DbSet<tb_ct_phieuphat> tb_ct_phieuphat { get; set; }
        public virtual DbSet<tb_ct_tacgia> tb_ct_tacgia { get; set; }
        public virtual DbSet<tb_dausach> tb_dausach { get; set; }
        public virtual DbSet<tb_docgia> tb_docgia { get; set; }
        public virtual DbSet<tb_NhanVien> tb_NhanVien { get; set; }
        public virtual DbSet<tb_phieubangiaosach> tb_phieubangiaosach { get; set; }
        public virtual DbSet<tb_phieuphat> tb_phieuphat { get; set; }
        public virtual DbSet<tb_sach> tb_sach { get; set; }
        public virtual DbSet<tb_tacgia> tb_tacgia { get; set; }
        public virtual DbSet<tb_Acount> tb_Acount { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_bb_nhanlaisach>()
                .HasMany(e => e.tb_ct_nhanlai)
                .WithRequired(e => e.tb_bb_nhanlaisach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_bb_nhanlaisach>()
                .HasMany(e => e.tb_phieuphat)
                .WithRequired(e => e.tb_bb_nhanlaisach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_dausach>()
                .HasMany(e => e.tb_ct_tacgia)
                .WithRequired(e => e.tb_dausach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_dausach>()
                .HasMany(e => e.tb_sach)
                .WithRequired(e => e.tb_dausach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_docgia>()
                .HasMany(e => e.tb_bb_nhanlaisach)
                .WithRequired(e => e.tb_docgia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_docgia>()
                .HasMany(e => e.tb_phieubangiaosach)
                .WithRequired(e => e.tb_docgia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_NhanVien>()
                .Property(e => e.taikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<tb_NhanVien>()
                .Property(e => e.matKhau)
                .IsUnicode(false);

            modelBuilder.Entity<tb_NhanVien>()
                .HasMany(e => e.tb_bb_nhanlaisach)
                .WithRequired(e => e.tb_NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_NhanVien>()
                .HasMany(e => e.tb_Acount)
                .WithRequired(e => e.tb_NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_NhanVien>()
                .HasMany(e => e.tb_phieubangiaosach)
                .WithRequired(e => e.tb_NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_phieubangiaosach>()
                .HasMany(e => e.tb_sach)
                .WithMany(e => e.tb_phieubangiaosach)
                .Map(m => m.ToTable("tb_ct_phieubangiao").MapLeftKey("maphieubangiao").MapRightKey("maquyensach"));

            modelBuilder.Entity<tb_phieuphat>()
                .HasMany(e => e.tb_ct_phieuphat)
                .WithRequired(e => e.tb_phieuphat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_sach>()
                .HasMany(e => e.tb_ct_nhanlai)
                .WithRequired(e => e.tb_sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_sach>()
                .HasMany(e => e.tb_ct_phieuphat)
                .WithRequired(e => e.tb_sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_tacgia>()
                .HasMany(e => e.tb_ct_tacgia)
                .WithRequired(e => e.tb_tacgia)
                .WillCascadeOnDelete(false);
        }


        [DbFunction("Model11", "FUN_LietKeTrangThai1DauSach")]
        public virtual IQueryable<FUN_LietKeTrangThai1DauSach_Result> FUN_LietKeTrangThai1DauSach(Nullable<int> iddausach)
        {
            var iddausachParameter = iddausach.HasValue ?
                new ObjectParameter("iddausach", iddausach) :
                new ObjectParameter("iddausach", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FUN_LietKeTrangThai1DauSach_Result>("[Model11].[FUN_LietKeTrangThai1DauSach](@iddausach)", iddausachParameter);
        }
        [DbFunction("Model11", "List1SACH")]
        public virtual IQueryable<List1SACH_Result> List1SACH()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<List1SACH_Result>("[Model11].[List1SACH]()");
        }
        [DbFunction("Model11", "ListALLQS")]
        public virtual IQueryable<ListALLQS_Result> ListALLQS(Nullable<int> iddausach)
        {
            var iddausachParameter = iddausach.HasValue ?
                new ObjectParameter("iddausach", iddausach) :
                new ObjectParameter("iddausach", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ListALLQS_Result>("[Model11].[ListALLQS](@iddausach)", iddausachParameter);
        }
    }

}
