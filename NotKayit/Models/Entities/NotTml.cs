namespace NotKayit.Models.Entities
{
    public class NotTml :BaseEntity
    {
        public int Id { get; set; }

        public int OgrenciTmlId { get; set; }
        public int DersId { get; set; }
        public int NotKodTmlId { get; set; }

        public double Deger { get; set; }

        // Navigation
        public OgrenciTml Ogrenci { get; set; } = null!;
        public DersTml Ders { get; set; } = null!;
        public NotKodTml NotKod { get; set; } = null!;
    }
}
