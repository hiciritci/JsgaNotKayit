using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace NotKayit.Models.ViewModels
{
    public class NotCreateViewModel
    {
        public long OgrenciTmlId { get; set; }

        public string OgrenciAdSoyad { get; set; } = "";

 
        [Display(Name = "Ders")]
        public int DersId { get; set; }


        [Display(Name = "Not Türü")]
        public long NotKodTmlId { get; set; }

       
        [Display(Name = "Not Değeri")]
        public double Deger { get; set; }

        public List<SelectListItem> Dersler { get; set; } = new();
        public List<SelectListItem> NotTurleri { get; set; } = new();
    }
}
