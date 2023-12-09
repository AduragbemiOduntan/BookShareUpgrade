using BookShare.Common.Enum;
using BookShare.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Infrastructure.Configuration
{
    public class TransporterConfiguration : IEntityTypeConfiguration<Transporter>
    {
        public void Configure(EntityTypeBuilder<Transporter> builder)
        {
            builder.HasData(
                    new List<Transporter>
                    {
                        new Transporter
                        {
                            UserId = new Guid("25d73632-0715-40df-aec6-e4833dacdca6").ToString(),
                            CompanyName = "Doretta and Company",
                            PhoneNumber = "09044553323",
                            DocumentType = DocumentType.Transporter,
                            LogoUrl = "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg",

                        },
                        new Transporter
                        {
                            UserId = new Guid("b017365a-2f2d-463d-8707-66a9b590839a").ToString(),
                            CompanyName = "On The Move Inc",
                            PhoneNumber = "09056653323",
                            DocumentType = DocumentType.Transporter,
                            LogoUrl = "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg",

                        },
                        new Transporter
                        {
                            UserId = new Guid("b017365a-2f2d-463d-8707-66a9b590839a").ToString(),
                            CompanyName = "On The Move Inc",
                            PhoneNumber = "09056653323",
                            DocumentType = DocumentType.Transporter,
                            LogoUrl = "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg",

                        }
                    }
                );
        }
    }
}
