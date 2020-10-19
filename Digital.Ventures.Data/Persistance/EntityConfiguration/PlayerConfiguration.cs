using Digital.Ventures.Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digital.Ventures.Data.Persistance.EntityConfiguration
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(player => player.Country).IsRequired();
            builder.Property(c => c.Name).IsRequired();
        }
    }
}

