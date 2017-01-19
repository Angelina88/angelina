using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    /// <summary>
    /// Данные о местах
    /// </summary>
    internal partial class Place : Entity
    {
        /// <summary>
        /// Описание условной группировки (может потребоваться клиентскому коду)
        /// </summary>
        [Column("groupname")]
        [Required(AllowEmptyStrings = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Описание адреса указания услуг в этом месте
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public string Address { get; set; }

        /// <summary>
        /// Признак доступности данного места для выбора клиенту
        /// </summary>
        [Column("isenabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Описание контактной информации
        /// </summary>
        [Column("contactinfo")]
        [Required(AllowEmptyStrings = true)]
        public string ContactInfo { get; set; }

        /// <summary>
        /// Движок очереди
        /// </summary>
        [Column("engineid")]
        public Guid EngineId { get; set; }
        public virtual Engine Engine { get; set; }

        /// <summary>
        /// Базовый адрес сервиса
        /// </summary>
        [Column("endpoint")]
        [Required(AllowEmptyStrings = true)]
        public string EndPoint { get; set; }

        /// <summary>
        /// Все остальные параметры
        /// </summary>
        [Column("attributesjson")]
        [Required(AllowEmptyStrings = true)]
        public string AttributesJson { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        [Column("cityid")]
        public Guid CityId { get; set; }
        public virtual City City { get; set; }

        /// <summary>
        /// Оригинальный идентификатор места от поставщика сервиса
        /// </summary>
        [Column("originalplaceid")]
        [Required(AllowEmptyStrings = true)]
        public string OriginalPlaceId { get; set; }

        /// <summary>
        /// Тип места
        /// </summary>
        [Column("placetypeid")]
        public Guid PlaceTypeId { get; set; }
    }
}
