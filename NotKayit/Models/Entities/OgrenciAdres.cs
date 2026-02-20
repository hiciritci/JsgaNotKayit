using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.Entities
{
    public class OgrenciAdres : BaseEntity
    {
        public int Id { get; set; }

        public int OgrenciTmlId { get; set; }

        [MaxLength(200)]
        public string? Adres { get; set; } 

        public OgrenciTml Ogrenci { get; set; }
    }
}
