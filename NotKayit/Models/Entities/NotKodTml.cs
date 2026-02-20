using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.Entities
{
    public class NotKodTml 
    {
        [Required,Key]
        public long Id { get; set; }

        [MaxLength(50)]
        public string Tur  { get; set; }
    }
}
