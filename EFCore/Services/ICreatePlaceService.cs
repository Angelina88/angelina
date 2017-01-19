using AutoMapper;
using EFCore.DBA;
using EFCore.Domain;
using EFCore.DTO;
using System;

namespace EFCore.Services
{
    /// <summary>
    /// Сервис добавления нового места
    /// </summary>
    public interface ICreatePlaceService : IService
    {
        /// <summary>
        /// Добавляет одно новое место
        /// </summary>
        /// <param name="placeDto">место</param>
        void Add(PlaceDto placeDto);
    }

    /// <summary>
    /// Сервис добавления нового места
    /// </summary>
    public class CreatePlaceService : ICreatePlaceService
    {
        private IDataProvider _provider;

        public CreatePlaceService(IDataProvider provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// Добавляет одно новое место
        /// </summary>
        /// <param name="placeDto">место</param>
        public void Add(PlaceDto placeDto)
        {
            var place = Mapper.Map<Place>(placeDto);
            place.Id = Guid.NewGuid();
            _provider.Create(place);
        }
    }
}
