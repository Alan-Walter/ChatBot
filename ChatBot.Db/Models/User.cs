using System;

namespace ChatBot.Db.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User : IEntity
    {
        /// <inheritdoc/>
        public long Id { get; set; }

        /// <inheritdoc/>
        public Guid Uid { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
    }
}
