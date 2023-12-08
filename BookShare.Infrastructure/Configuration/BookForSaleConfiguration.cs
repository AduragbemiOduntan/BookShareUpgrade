using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShare.Domain.Model;
using System.Reflection.Emit;

namespace BookShare.Infrastructure.Configuration
{
    public class BookForSaleConfiguration : IEntityTypeConfiguration<BookForSale>
    {
        public void Configure(EntityTypeBuilder<BookForSale> builder)
        {
            builder.Property(b => b.EducationLevel)
                        .HasColumnName("EducationLevel");
            builder.Property(b => b.EducationLevel)
                        .HasColumnName("BookCategory");
            builder.Property(b => b.EducationLevel)
                        .HasColumnName("BookCondition");
            builder.Property(b => b.EducationLevel)
                        .HasColumnName("ListingType");
            builder.Property(b => b.EducationLevel)
                   .HasColumnName("Subject");
        }
    }
}
