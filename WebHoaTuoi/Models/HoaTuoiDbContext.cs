using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebHoaTuoi.Models
{
    public class HoaTuoiDbContext : DbContext
    {
        public HoaTuoiDbContext() : base("name=HoaTuoiDbContext")
        {
            Database.SetInitializer(new HoaTuoiDbInitializer());
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<SanPham>()
                .HasRequired(s => s.LoaiSP)
                .WithMany(l => l.SanPhams)
                .HasForeignKey(s => s.MaLoaiSP)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
