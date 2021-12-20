using FirstTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask.Configurations
{
    public class TipsConfig : IEntityTypeConfiguration<Tip>
    {
        public void Configure(EntityTypeBuilder<Tip> builder)
        {
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.description).IsRequired();
            builder.Property(p => p.VideoPath).IsRequired();
        }
    }
}
