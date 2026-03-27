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
            CreateMap<NotCreateViewModel,NotTml>();
            CreateMap<NotTml, OgrenciNotItemVm>()
           .ForMember(d => d.DersAd, o => o.MapFrom(s => s.Ders.DersAd))
           .ForMember(d => d.NotTur, o => o.MapFrom(s => s.NotKod.Tur));
        }
    }
}