using EFCore.Domain;
using EFCore.DTO;
using System.Collections.Generic;
using EFCore.DBA;
using AutoMapper;
using System.Linq.Expressions;
using System.Linq;

namespace EFCore.Services
{
    /// <summary>
    /// Сервис выбора сущностей
    /// </summary>
    public interface ISelectEntityService : IService
    {
        /// <summary>
        /// Выбирает сущности типа T и преобразовывает в TDto
        /// </summary>
        /// <typeparam name="T">тип доменной сущности</typeparam>
        /// <typeparam name="TDto">тип сущности представления</typeparam>
        /// <returns>список сущностей представления</returns>
        IEnumerable<TDto> SelectAll<T, TDto>() where T : Entity where TDto : EntityDto;
    }


    /// <summary>
    /// Сервис выбора сущностей
    /// </summary>
    public class SelectEntityService : ISelectEntityService
    {
        private IDataProvider _provider;

        public SelectEntityService(IDataProvider provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// Выбирает сущности типа T и преобразовывает в TDto
        /// </summary>
        /// <typeparam name="T">тип доменной сущности</typeparam>
        /// <typeparam name="TDto">тип сущности представления</typeparam>
        /// <returns>список сущностей представления</returns>
        public IEnumerable<TDto> SelectAll<T, TDto>()
            where T : Entity
            where TDto : EntityDto
        {
            var includes = typeof(T).GetProperties()
                                        .Where(prop => prop.PropertyType.IsSubclassOf(typeof(Entity)) 
                                                && prop.GetGetMethod().IsVirtual)
                                            .Select(p => p.Name);
            var entitys = _provider.Select<T>(includes);
            return Mapper.Map<IEnumerable<TDto>>(entitys);
        }
    }
}
