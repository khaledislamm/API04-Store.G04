using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Store.G04.persistence.Data.Configurations
{
    public class BroductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.Property(T => T.Name).HasColumnType("varchar").HasMaxLength(256);

        }
    }
}
