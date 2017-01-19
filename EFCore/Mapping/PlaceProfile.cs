using AutoMapper;
using EFCore.Domain;
using EFCore.DTO;

namespace EFCore.Mapping
{
    /// <summary>
    /// Конфигурация маппинга мест
    /// </summary>
    public class PlaceProfile : Profile
    {
        public PlaceProfile()
        {
            CreateMap<Place, PlaceDto>()
                .ForMember(dto => dto.EngineName, opt => opt.MapFrom(p => p.Engine.Name))
                .ForMember(dto => dto.CityName, opt => opt.MapFrom(p => p.City.Name));

            CreateMap<PlaceDto, Place>()
                .ForMember(ent => ent.Engine, opt => opt.Ignore())
                .ForMember(ent => ent.City, opt => opt.Ignore());
        }
    }
}
