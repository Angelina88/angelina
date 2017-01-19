using AutoMapper;
using EFCore.Domain;
using EFCore.DTO;

namespace EFCore.Mapping
{
    /// <summary>
    /// Конфигурация маппинга доменов в базовое представление
    /// </summary>
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<Engine, EntityDto>();

            CreateMap<City, EntityDto>();
        }
    }
}
