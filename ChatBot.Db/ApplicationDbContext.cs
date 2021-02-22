using ChatBot.Db.Models;

using Microsoft.EntityFrameworkCore;

namespace ChatBot.Db
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Пользователи
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Конфигурирование модели
        /// </summary>
        /// <param name="modelBuilder">Билдер модели</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
