using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Domain
{
    /// <summary>
    /// Домен
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Key]
        [Column("recid")]
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [Column("recname")]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        /// <summary>
        /// Дата создания записи
        /// </summary>
        [Column("reccreated")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Дата изменения записи
        /// </summary>
        [Column("recupdated")]
        public DateTime Updated { get; set; }
    }
}
