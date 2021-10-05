using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenVietDiep.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }

        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        public virtual DbSet<Class1> Class1s  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>()
                .Property(e => e.TenLop)
                .IsUnicode(false);
        }
    }
}
