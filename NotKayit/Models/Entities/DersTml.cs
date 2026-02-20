using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace NotKayit.Models.Entities
{
    public class DersTml : BaseEntity
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string DersAd { get; set; } 

        public short KrediSayisi { get; set; } 

        public int DersAlanKodId { get; set; }
        public DersAlanKodTml DersAlanKod { get; set; } = null!;
        public ICollection<NotTml> Notlar { get; set; } = new List<NotTml>();
        public ICollection<OgrenciDers> OgrenciDersler { get; set; } = new List<OgrenciDers>();
    }
}
