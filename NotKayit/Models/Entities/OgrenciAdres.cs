using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.Entities
{
    public class OgrenciAdres : BaseEntity
    {
        public int Id { get; set; } 
        [MaxLength(200)]
        public string? Adres { get; set; }
        public long OgrenciTmlId { get; set; }
        public OgrenciTml OgrenciTml { get; set; }
    }
}
