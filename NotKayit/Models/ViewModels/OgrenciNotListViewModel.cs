namespace NotKayit.Models.ViewModels
{

    public class OgrenciNotListViewModel
    {
        public long OgrenciId { get; set; }
        public string OgrenciAdSoyad { get; set; } = "";
        public List<OgrenciNotItemVm> Notlar { get; set; } = new();
    }

    public class OgrenciNotItemVm
    {
        public int Id { get; set; }
        public string DersAd { get; set; } = "";
        public string NotTur { get; set; } = "";
        public double Deger { get; set; }
    }

}
