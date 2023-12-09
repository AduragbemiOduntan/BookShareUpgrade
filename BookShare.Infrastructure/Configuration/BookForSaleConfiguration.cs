using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShare.Domain.Model;
using System.Reflection.Emit;
using BookShare.Common.Enum;

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

            //Seeding Data
            builder.HasData(
                new BookForSale
                {
                    BookForSaleId = "25a9cfcc-24c3-4fe4-83ef-6f82e8704b4e",
                    BookName = "Introduction to Economics",
                    BookDescription = "Economics textbook",
                    Author = "John Doe",
                    EducationLevel = EducationLevel.SS1,
                    BookCategory = BookCategory.Science,
                    Subject = Subject.Economics,
                    MarketPrice = 29.99m,
                    SellingPrice = 19.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Fair,
                    ISBN = "978-0-123-45678-9",
                    ListingType = ListingType.Paid,
                    IsDisabled = true,
                },
                new BookForSale
                {
                    BookForSaleId = "8eb4f536-7680-4a77-9f84-3c6ac75c77d2",
                    BookName = "Macroeconomics Explained",
                    BookDescription = "Macroeconomics textbook",
                    Author = "Jane Smith",
                    EducationLevel = EducationLevel.SS2,
                    BookCategory = BookCategory.Commercial,
                    Subject = Subject.Economics,
                    MarketPrice = 39.99m,
                    SellingPrice = 29.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Good,
                    ISBN = "978-0-987-65432-1",
                    ListingType = ListingType.Free,
                    HarmfulContentCount = 5,
                },
                 new BookForSale
                 {
                     BookForSaleId = "3fcd4fe1-d8b7-4f9a-8625-8c92c8317409",
                     BookName = "Introduction to Physics",
                     BookDescription = "Physics textbook for beginners",
                     Author = "John Doe",
                     EducationLevel = EducationLevel.SS3,
                     BookCategory = BookCategory.Science,
                     Subject = Subject.Physics,
                     MarketPrice = 49.99m,
                     SellingPrice = 39.99m,
                     ListedDate = DateTime.UtcNow,
                     BookCondition = BookCondition.New,
                     ISBN = "978-1-234-56789-0",
                     ListingType = ListingType.Paid,
                     HarmfulContentCount = 4,
                 },
                new BookForSale
                {
                    BookForSaleId = "fd6726e7-0dbb-4e4c-bc29-4cd4c6e8ecf7",
                    BookName = "English Grammar Essentials",
                    BookDescription = "Grammar guide for language learners",
                    Author = "Alice Johnson",
                    EducationLevel = EducationLevel.JSS2,
                    BookCategory = BookCategory.Others,
                    Subject = Subject.English,
                    MarketPrice = 29.99m,
                    SellingPrice = 19.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Fair,
                    ISBN = "978-2-345-67890-1",
                    ListingType = ListingType.Paid,
                    IsDisabled = true,
                    HarmfulContentCount = 5,
                },
                new BookForSale
                {
                    BookForSaleId = "0bb6a6f4-d16a-4fbf-bf23-926b4987ff7a",
                    BookName = "Introduction to Business Studies",
                    BookDescription = "Business studies textbook",
                    Author = "Robert Miller",
                    EducationLevel = EducationLevel.SS1,
                    BookCategory = BookCategory.Commercial,
                    Subject = Subject.BusinessStudies,
                    MarketPrice = 34.99m,
                    SellingPrice = 24.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Good,
                    ISBN = "978-3-456-78901-2",
                    ListingType = ListingType.Paid,
                    IsDisabled = true,
                    HarmfulContentCount = 3,
                },
                new BookForSale
                {
                    BookForSaleId = "1b55e794-02ce-48c4-b2a1-49770e97c158",
                    BookName = "Chemistry Basics",
                    BookDescription = "Introduction to chemistry",
                    Author = "Emily White",
                    EducationLevel = EducationLevel.JSS1,
                    BookCategory = BookCategory.Science,
                    Subject = Subject.Chemistry,
                    MarketPrice = 27.99m,
                    SellingPrice = 17.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Used,
                    ISBN = "978-4-567-89012-3",
                    ListingType = ListingType.Free,
                },
                new BookForSale
                {
                    BookForSaleId = "6e7e78a5-2b1e-4a71-b1a2-5b35bf7e7c2c",
                    BookName = "Computer Science Fundamentals",
                    BookDescription = "Introduction to computer science",
                    Author = "Michael Brown",
                    EducationLevel = EducationLevel.SS2,
                    BookCategory = BookCategory.Technology,
                    Subject = Subject.Computer,
                    MarketPrice = 39.99m,
                    SellingPrice = 29.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.New,
                    ISBN = "978-5-678-90123-4",
                    ListingType = ListingType.Free,
                },
                 new BookForSale
                 {
                     BookForSaleId = "9a1d8c0a-b7c4-43aa-89a2-9109d77477db",
                     BookName = "History Uncovered",
                     BookDescription = "Exploring historical events",
                     Author = "David Thompson",
                     EducationLevel = EducationLevel.SS3,
                     BookCategory = BookCategory.Others,
                     Subject = Subject.SocialStudies,
                     MarketPrice = 44.99m,
                     SellingPrice = 34.99m,
                     ListedDate = DateTime.UtcNow,
                     BookCondition = BookCondition.Good,
                     ISBN = "978-6-789-01234-5",
                     ListingType = ListingType.Paid,
                 },
                new BookForSale
                {
                    BookForSaleId = "b3268c1b-04d0-4d07-b393-853e228f5aaf",
                    BookName = "Math Puzzles and Challenges",
                    BookDescription = "Fun math problems for enthusiasts",
                    Author = "Sophie Clark",
                    EducationLevel = EducationLevel.SS2,
                    BookCategory = BookCategory.Science,
                    Subject = Subject.Mathematics,
                    MarketPrice = 19.99m,
                    SellingPrice = 9.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.New,
                    ISBN = "978-7-890-12345-6",
                    ListingType = ListingType.Free,
                },
                new BookForSale
                {
                    BookForSaleId = "3b59a7f2-91a0-4991-bb2b-3ee5d779d15b",
                    BookName = "Literary Classics Collection",
                    BookDescription = "A compilation of classic literature",
                    Author = "Charlotte Williams",
                    EducationLevel = EducationLevel.SS1,
                    BookCategory = BookCategory.Others,
                    Subject = Subject.Literature,
                    MarketPrice = 54.99m,
                    SellingPrice = 44.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Fair,
                    ISBN = "978-8-901-23456-7",
                    ListingType = ListingType.Paid,
                },
                new BookForSale
                {
                    BookForSaleId = "735bf9c0-947a-4b29-b3c4-0e8eab31c34b",
                    BookName = "Physics for Beginners",
                    BookDescription = "Fundamental concepts of physics",
                    Author = "Daniel Turner",
                    EducationLevel = EducationLevel.JSS1,
                    BookCategory = BookCategory.Science,
                    Subject = Subject.Physics,
                    MarketPrice = 29.99m,
                    SellingPrice = 19.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Used,
                    ISBN = "978-9-012-34567-8",
                    ListingType = ListingType.Paid,
                },
                new BookForSale
                {
                    BookForSaleId = "7e6e1b1d-7d91-45d7-a9d4-0e953ab12c3a",
                    BookName = "Art Appreciation",
                    BookDescription = "Discovering the world of art",
                    Author = "Olivia Davis",
                    EducationLevel = EducationLevel.JSS2,
                    BookCategory = BookCategory.Art,
                    Subject = Subject.Others,
                    MarketPrice = 34.99m,
                    SellingPrice = 24.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Good,
                    ISBN = "978-0-111-22222-2",
                    ListingType = ListingType.Free,
                },
                new BookForSale
                {
                    BookForSaleId = "5f1c6d9a-3e85-46b0-b7c4-1e7df41e084e",
                    BookName = "Business Ethics",
                    BookDescription = "Understanding ethical business practices",
                    Author = "Ryan Mitchell",
                    EducationLevel = EducationLevel.SS3,
                    BookCategory = BookCategory.Commercial,
                    Subject = Subject.BusinessStudies,
                    MarketPrice = 39.99m,
                    SellingPrice = 29.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.New,
                    ISBN = "978-3-333-44444-4",
                    ListingType = ListingType.Paid,
                },
                new BookForSale
                {
                    BookForSaleId = "8eaa6d2b-e4cc-4c48-9205-8ef9f2c2c5b8",
                    BookName = "Environmental Science",
                    BookDescription = "Exploring the environment and ecosystems",
                    Author = "Emma Turner",
                    EducationLevel = EducationLevel.SS1,
                    BookCategory = BookCategory.Science,
                    Subject = Subject.EnvironmentalScience,
                    MarketPrice = 49.99m,
                    SellingPrice = 39.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Good,
                    ISBN = "978-5-555-66666-6",
                    ListingType = ListingType.Free,
                },
                new BookForSale
                {
                    BookForSaleId = "d450b2f3-4d20-4d22-8d4e-4e6ef3a429b3",
                    BookName = "Philosophy Fundamentals",
                    BookDescription = "Introduction to philosophical concepts",
                    Author = "Sophia Johnson",
                    EducationLevel = EducationLevel.SS2,
                    BookCategory = BookCategory.Others,
                    Subject = Subject.Philosophy,
                    MarketPrice = 24.99m,
                    SellingPrice = 14.99m,
                    ListedDate = DateTime.UtcNow,
                    BookCondition = BookCondition.Fair,
                    ISBN = "978-6-666-77777-7",
                    ListingType = ListingType.Paid,
                }
            );
        }
    }
}
