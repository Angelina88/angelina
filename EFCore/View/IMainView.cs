using EFCore.DTO;
using System;
using System.Collections.Generic;

namespace EFCore.View
{
    /// <summary>
    /// Вид главного окна
    /// </summary>
    public interface IMainView : IView
    {
        /// <summary>
        /// Заполнить движки очередей
        /// </summary>
        /// <param name="list">список представлений движков очередей</param>
        void FillEngines(IEnumerable<EntityDto> list);
        /// <summary>
        /// Заполнить города
        /// </summary>
        /// <param name="list">список представлений городов</param>
        void FillCities(IEnumerable<EntityDto> list);
        /// <summary>
        /// Заполнить места
        /// </summary>
        /// <param name="list"></param>
        void FillPlaces(IEnumerable<PlaceDto> list);
        /// <summary>
        /// Добавить место
        /// </summary>
        /// <param name="row"></param>
        void AddPlace(PlaceDto row);
        /// <summary>
        /// Получить новое место с формы
        /// </summary>
        /// <returns></returns>
        PlaceDto GetNewRecord();

        /// <summary>
        /// Событие окончания загрузки формы
        /// </summary>
        event Action FormLoaded;
        /// <summary>
        /// Событие добавления новой записи на форме
        /// </summary>
        event Action AddRecord;

    }
}
