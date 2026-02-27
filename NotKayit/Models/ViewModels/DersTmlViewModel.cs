using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.ViewModels
{
    public class DersTmlViewModel
    { 
        public int Id { get; set; }  
        public string DersAd { get; set; } 
        public short KrediSayisi { get; set; }
        public string? DersAlanTur { get; set; }
        public int? DersAlanKodTmlId { get; set; }
    }
}
