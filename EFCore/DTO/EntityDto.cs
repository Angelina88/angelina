using System;
using System.ComponentModel;

namespace EFCore.DTO
{
    /// <summary>
    /// Общее представление сущностей
    /// </summary>
    public class EntityDto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Наименовани сущности
        /// </summary>
        [DisplayName("Наименование")]
        public string Name { get; set; }

        /// <summary>
        /// Дата создания сущности
        /// </summary>
        [DisplayName("Создана")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Дата обновления сущности
        /// </summary>
        [DisplayName("Обновлена")]
        public DateTime Updated { get; set; }
    }
}
