using System;

namespace ChatBot.Db.Models
{
    /// <summary>
    /// Сущность базы данных
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        Guid Uid { get; set; }
    }
}
