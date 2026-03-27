namespace NotKayit.Models.Entities
{
    public class NotTml :BaseEntity
    {
        public int Id { get; set; }

        public long OgrenciTmlId { get; set; }
        public int DersId { get; set; }
        public long NotKodTmlId { get; set; }

        public double Deger { get; set; }

        // Navigation
        public OgrenciTml Ogrenci { get; set; } = null!;
        public DersTml Ders { get; set; } = null!;
        public NotKodTml NotKod { get; set; } = null!;
    }
}
