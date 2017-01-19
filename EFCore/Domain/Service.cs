using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    /// <summary>
    /// Данные об услугах
    /// </summary>
    internal partial class Service : Entity
    {
        /// <summary>
        /// Оригинальное наименование услуги - от поставщика сервиса
        /// </summary>
        [Column("originalservicename")]
        public string OriginalServiceName { get; set; }

        /// <summary>
        /// Оригинальный идентификатор услуги - от поставщика сервиса
        /// </summary>
        [Column("originalserviceid")]
        public string OriginalServiceId { get; set; }

        /// <summary>
        /// Место предоставления услуги
        /// </summary>
        [Column("placeid")]
        public Guid PlaceId { get; set; }
        public virtual Place Place { get; set; }

        /// <summary>
        /// Признак доступности данной услуги для выбора клиенту
        /// </summary>
        [Column("isenabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Признак наличия этапов, выполняемых специалистом
        /// </summary>
        [Column("isspecialiststepexists")]
        public bool SpecialistStepExists { get; set; }

        /// <summary>
        /// Признак возможности бронирования услуги
        /// </summary>
        [Column("isbookingexists")]
        public bool BookingExists { get; set; }

        /// <summary>
        /// Признак возможности отмены бронирования услуги
        /// </summary>
        [Column("Iscancelbookingexists")]
        public bool CancelBookingExists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("iscancelbookingexists")]
        public bool CancelServiceExists { get; set; }

        /// <summary>
        /// Все остальные параметры
        /// </summary>
        [Column("attributesjson")]
        public string AttributesJson { get; set; }
    }
}
