using AutoMapper;
using NotKayit.Models.Entities;
using NotKayit.Models.ViewModels; 
namespace NotKayit.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {  
            CreateMap<OgrenciTml, OgrenciTmlViewModel>().ReverseMap(); 
            CreateMap<DersTml, CreateDersTmlViewModel>().ReverseMap();
            CreateMap<DersTml,DersTmlViewModel >().ReverseMap();
        }
    }
}