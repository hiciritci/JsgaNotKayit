namespace NotKayit.Models.ViewModels
{
    public class OgrenciTmlViewModel
    {

        public long Id { get; set; } 
        public string Ad { get; set; }  
        public string Soyad { get; set; } 
        public DateTime DogumTarihi { get; set; }
        public int Yas { get; set; }

        public string Cinsiyet { get; set; }
    }
}
