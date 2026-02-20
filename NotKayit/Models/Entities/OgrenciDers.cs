namespace NotKayit.Models.Entities
{
    public class OgrenciDers:BaseEntity
    {
        public int Id { get; set; }

        public long OgrenciTmlId { get; set; }
      
        public OgrenciTml OgrenciTml { get; set; } 
        public int DersTmlId { get; set; }  
        public DersTml DersTml { get; set; } 
    }
}
