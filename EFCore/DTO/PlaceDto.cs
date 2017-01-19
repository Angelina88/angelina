using System;
using System.ComponentModel;

namespace EFCore.DTO
{
    /// <summary>
    /// Представление сущности места
    /// </summary>
    public class PlaceDto : EntityDto
    {
        /// <summary>
        /// Группировка
        /// </summary>
        [DisplayName("Группа")]
        public string GroupName { get; set; }

        /// <summary>
        /// Адрес места
        /// </summary>
        [DisplayName("Адрес")]
        public string Address { get; set; }

        /// <summary>
        /// Признак доступности для выбора клиентом
        /// </summary>
        [DisplayName("Доступна")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Контактная информация
        /// </summary>
        [DisplayName("Контактная информация")]
        public string ContactInfo { get; set; }
        
        /// <summary>
        /// Движок очереди
        /// </summary>
        public Guid EngineId { get; set; }
        [DisplayName("Очередь")]
        public string EngineName { get; set; }

        /// <summary>
        /// Базовый адрес сервиса
        /// </summary>
        [DisplayName("Базовый адрес")]
        public string EndPoint { get; set; }

        /// <summary>
        /// Дополнительные параметры
        /// </summary>
        [DisplayName("Параметры")]
        public string AttributesJson { get; set; }
        
        /// <summary>
        /// Город
        /// </summary>
        public Guid CityId { get; set; }
        [DisplayName("Город")]
        public string CityName { get; set; }

        /// <summary>
        /// Внешний идентификатор места
        /// </summary>
        [DisplayName("Внешний идентификатор места")]
        public string OriginalPlaceId { get; set; }

        /// <summary>
        /// Идентификатор типа места
        /// </summary>
        [DisplayName("Идентификатор типа места")]
        public Guid PlaceTypeId { get; set; }
    }
}
