using BookShare.Common.Enum;
using BookShare.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                    new List<User>
                    {
                        new User
                        {
                            UserId = new Guid("25d73632-0715-40df-aec6-e4833dacdca6").ToString(),
                            FirstName = "Doretta",
                            LastName = "Dunphie",
                            Email = "ddunphie0@amazon.com",
                            EmailConfirmed = true,
                            ImageUrl = "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg",
                            UserType = UserType.Transporter
                        },
                        new User
                        {
                            UserId = new Guid("b017365a-2f2d-463d-8707-66a9b590839a").ToString(),
                            FirstName = "Chane",
                            LastName = "Mounch",
                            Email = "cmounch1@behance.net",
                            EmailConfirmed = true,
                            ImageUrl = "https://images.pexels.com/photos/2379004/pexels-photo-2379004.jpeg",
                            UserType = UserType.Transporter
                        },
                        new User
                        {
                            UserId = new Guid("e62dfff9-e41d-426c-acda-f0638d5d9d5b").ToString(),
                            FirstName = "Pyotr",
                            LastName = "Walesby",
                            Email = "pwalesby2@addthis.com",
                            EmailConfirmed = true,
                            ImageUrl = "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg",
                            UserType = UserType.Transporter
                        },
                    }
                );
        }
    }
}
