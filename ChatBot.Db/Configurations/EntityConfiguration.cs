using ChatBot.Db.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Db.Configurations
{
    /// <summary>
    /// Конфигуратор сущности
    /// </summary>
    /// <typeparam name="TEntity">Сущность</typeparam>
    public abstract class EntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity
    {
        /// <inheritdoc/>
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder
                .HasKey(i => i.Id);

            builder
                .HasIndex(i => i.Uid)
                .IsUnique(true);
        }
    }
}
