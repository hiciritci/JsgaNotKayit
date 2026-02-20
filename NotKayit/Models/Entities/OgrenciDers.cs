namespace NotKayit.Models.Entities
{
    public class OgrenciDers:BaseEntity
    {
        public int Id { get; set; }

        public int OgrenciTmlId { get; set; }
        public int DersId { get; set; }  
        public OgrenciTml Ogrenci { get; set; } = null!;
        public DersTml Ders { get; set; } = null!;
    }
}
