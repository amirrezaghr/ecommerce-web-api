using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Summery).HasMaxLength(400);
            builder.HasKey(x => x.Id);
        }
    }
}
