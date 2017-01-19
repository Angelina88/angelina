using EFCore.Domain;
using System.Collections.Generic;

namespace EFCore.DBA
{
    /// <summary>
    /// Доступ к базе данных
    /// </summary>
    public interface IDataProvider
    {
        /// <summary>
        /// Выбирает записи домена
        /// </summary>
        /// <typeparam name="T">тип домена</typeparam>
        /// <param name="includes">дополнительно загружаемые зависимости</param>
        /// <returns>список объектов</returns>
        IEnumerable<T> Select<T>(IEnumerable<string> includes) 
            where T : Entity;

        /// <summary>
        /// Вставляет запись в базу
        /// </summary>
        /// <typeparam name="T">тип домена</typeparam>
        /// <param name="entity">добавляемый объект</param>
        void Create<T>(T entity) where T : Entity;
    }
}
