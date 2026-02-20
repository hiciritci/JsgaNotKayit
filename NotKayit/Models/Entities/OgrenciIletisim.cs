using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace NotKayit.Models.Entities
{
    public class OgrenciIletisim :BaseEntity
    {
        public long Id { get; set; }

        [MaxLength(100)]
        public string Email  { get; set; } 
        public long Telefon { get; set; } 
        public long OgrenciTmlId { get; set; }
        public OgrenciTml OgrenciTml { get; set; }
    }
}
