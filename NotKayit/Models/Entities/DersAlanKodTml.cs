using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.Entities
{
    public class DersAlanKodTml
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string? Tur { get; set; }
      
    }
}
