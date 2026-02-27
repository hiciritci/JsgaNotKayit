using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.ViewModels
{
    public class CreateDersTmlViewModel
    {
        [Required, MaxLength(100)]
        public string DersAd { get; set; } = "";

        public short KrediSayisi { get; set; }

        [Required]
        public int DersAlanKodTmlId { get; set; }

        // dropdown için
        public List<SelectListItem> Alanlar { get; set; } = new();
    }
}
