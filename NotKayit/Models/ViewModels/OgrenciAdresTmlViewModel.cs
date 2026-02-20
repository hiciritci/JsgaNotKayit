using NotKayit.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.ViewModels
{
    public class OgrenciAdresTmlViewModel
    {

        public long OgrenciTmlId { get; set; }

        [Required(ErrorMessage = "Adres zorunludur")]
        public string Adres { get; set; }

        // Sayfada mevcut adresleri göstermek için
        public List<OgrenciAdresItemVm> AdresListesi { get; set; } = new();


        public class OgrenciAdresItemVm
        {
            public long Id { get; set; }
            public string Adres { get; set; }
        }
    }
}
