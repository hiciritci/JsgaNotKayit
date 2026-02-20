using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.Entities
{
    public sealed class OgrenciTml : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required, StringLength(50)]
        public string Ad { get; set; }

        [Required, StringLength(50)]
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        [Required, StringLength(5)]
        public string Cinsiyet { get; set; }

        [StringLength(100)]
        public string? EMail { get; set; }

    }
}
