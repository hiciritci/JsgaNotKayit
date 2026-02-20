using Microsoft.EntityFrameworkCore;
using NotKayit.Models.Entities;

namespace NotKayit.Models.DataContext
{
    public class NotKayitDbContext :DbContext
    {
        public NotKayitDbContext(DbContextOptions<NotKayitDbContext> options) : base(options) { }

        public DbSet<OgrenciIletisim> OgrenciIletisim  { get; set; }
        public DbSet<OgrenciTml> OgrenciTml { get; set; }
        public DbSet<NotKodTml> NotKodTml  { get; set; }
        public DbSet<DersAlanKodTml> DersAlanKodTml { get; set; }
        public DbSet<DersTml> DersTml { get; set; }
        public DbSet<NotTml> NotTml { get; set; }
        public DbSet<OgrenciAdres> OgrenciAdres { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }

    }
}
