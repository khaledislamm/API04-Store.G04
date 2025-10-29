using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Store.G04.persistence.Data.Configurations
{
    public class ProductBrandConfiguration : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.Property(B => B.Name).HasColumnType("varchar").HasMaxLength(256);

        }
    }
}
