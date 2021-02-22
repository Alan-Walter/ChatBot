using ChatBot.Db.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatBot.Db.Configurations
{
    /// <summary>
    /// Конфигурация модели пользователя
    /// </summary>
    internal class UserConfiguration : EntityConfiguration<User>
    {
        /// <inheritdoc/>
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasIndex(i => i.Login)
                .IsUnique(true);

            builder.Property(i => i.Password)
                .IsRequired(true);
        }
    }
}
