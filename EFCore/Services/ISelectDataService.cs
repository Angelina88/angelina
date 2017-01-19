using EFCore.DTO;
using System.Collections.Generic;
using EFCore.Domain;

namespace EFCore.Services
{
    /// <summary>
    /// Сервис выбора данных
    /// </summary>
    public interface ISelectDataService : IService
    {
        /// <summary>
        /// Выбирает места
        /// </summary>
        /// <returns>список мест</returns>
        IEnumerable<PlaceDto> SelectPlaces();

        /// <summary>
        /// Выбирает движки очереди
        /// </summary>
        /// <returns>список движков очередей</returns>
        IEnumerable<EntityDto> SelectEngines();

        /// <summary>
        /// Выбирает список городов
        /// </summary>
        /// <returns>список городов</returns>
        IEnumerable<EntityDto> SelectCities();
    }

    /// <summary>
    /// Сервис выбора данных
    /// </summary>
    public class SelectDataService : ISelectDataService
    {
        private ISelectEntityService _selectEntityService;

        public SelectDataService(ISelectEntityService selectEntityService)
        {
            _selectEntityService = selectEntityService;
        }

        /// <summary>
        /// Выбирает список городов
        /// </summary>
        /// <returns>список городов</returns>
        public IEnumerable<EntityDto> SelectCities()
        {
            return _selectEntityService.SelectAll<City, EntityDto>();
        }

        /// <summary>
        /// Выбирает движки очереди
        /// </summary>
        /// <returns>список движков очередей</returns>
        public IEnumerable<EntityDto> SelectEngines()
        {
            return _selectEntityService.SelectAll<Engine, EntityDto>();
        }

        /// <summary>
        /// Выбирает места
        /// </summary>
        /// <returns>список мест</returns>
        public IEnumerable<PlaceDto> SelectPlaces()
        {
            return _selectEntityService.SelectAll<Place, PlaceDto>();
        }
    }
}
