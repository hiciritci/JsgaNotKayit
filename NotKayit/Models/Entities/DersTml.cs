using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace NotKayit.Models.Entities
{
    public class DersTml : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string DersAd { get; set; } 

        public short KrediSayisi { get; set; } 

        public int DersAlanKodTmlId { get; set; }
        public DersAlanKodTml DersAlanKodTml { get; set; } = null!;
        public ICollection<NotTml> Notlar { get; set; } = new List<NotTml>();
        public ICollection<OgrenciDers> OgrenciDersler { get; set; } = new List<OgrenciDers>();
    }
}
