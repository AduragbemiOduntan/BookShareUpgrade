using BookShare.Common.Enum;
using BookShare.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                 //Text-Books
                 new BookForSale
                 {
                     BookForSaleId = "b946508d-6a67-4f2e-93b0-2f1d15cb482e\r\n",
                     BookName = "An Introduction to Economics",
                     BookDescription = "Comprehensive introduction to economic theories and principles.",
                     BookCategory = BookCategory.TextBook,
                     MarketPrice = 8000.00m,
                     SellingPrice = 2000.00m,
                     ImageUrl = "https://ibb.co/qsTTbGv"
                 },

                new BookForSale
                {
                    BookForSaleId = "f7c8e0ae-3fb7-4e49-a42d-59b40698665a",
                    BookName = "Business Studies",
                    BookDescription = "In-depth exploration of business concepts and strategies.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 9000.00m,
                    SellingPrice = 4000.00m,
                    ImageUrl = "https://ibb.co/m45tnVm"
                },

                new BookForSale
                {
                    BookForSaleId = "9b03f725-521f-4a90-9f4a-7c5b89c2465c",
                    BookName = "Literature",
                    BookDescription = "An engaging collection of literary masterpieces.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 2499.99m,
                    SellingPrice = 1299.99m,
                    ImageUrl = "https://ibb.co/WVzW49p"
                },

                new BookForSale
                {
                    BookForSaleId = "90a1eb50-5e54-41b2-b5b9-5d3d25f7e031",
                    BookName = "Computer Programming for Beginners",
                    BookDescription = "A beginner-friendly guide to computer programming.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 5999.99m,
                    SellingPrice = 2999.99m,
                    ImageUrl = "https://ibb.co/Q6XsX4J"
                },

                new BookForSale
                {
                    BookForSaleId = "e40bb26b-6f9b-4a53-b8dd-0c1cfb9daee2",
                    BookName = "World History",
                    BookDescription = "Exploring the rich tapestry of global historical events.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 2999.99m,
                    SellingPrice = 1499.99m,
                    ImageUrl = "https://ibb.co/ZhBXwtS"
                },

                new BookForSale
                {
                    BookForSaleId = "c93cf864-d273-44d2-98b3-b36138de7b9b",
                    BookName = "Master Practical Chemistry",
                    BookDescription = "Practical insights and experiments in the field of chemistry.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 3499.99m,
                    SellingPrice = 1999.99m,
                    ImageUrl = "https://ibb.co/qDDskmB"
                },

                new BookForSale
                {
                    BookForSaleId = "1cfc1884-2aae-4ac1-97c5-27f408f140f3",
                    BookName = "SSCE and UTME Physics",
                    BookDescription = "Comprehensive physics guide for SSCE and UTME exams.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 3999.99m,
                    SellingPrice = 2499.99m,
                    ImageUrl = "https://ibb.co/NTMt2Sv"
                },

                new BookForSale
                {
                    BookForSaleId = "a39b8e55-7a88-4912-9d08-45b33c550a6e",
                    BookName = "Organic Chemistry",
                    BookDescription = "In-depth study of organic chemistry principles and reactions.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 4499.99m,
                    SellingPrice = 2999.99m,
                    ImageUrl = "https://ibb.co/ncsvd1j"
                },

                new BookForSale
                {
                    BookForSaleId = "55f7d2a7-3b49-4e87-88c0-6c88e2a0e17c",
                    BookName = "New General Mathematics",
                    BookDescription = "Comprehensive guide to general mathematical concepts.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 3999.99m,
                    SellingPrice = 1999.99m,
                    ImageUrl = "https://ibb.co/6RkfmFB"
                },

                new BookForSale
                {
                    BookForSaleId = "d764f82c-e4e1-4e50-825e-54c8b8b8eeb1",
                    BookName = "New School Physics",
                    BookDescription = "Physics textbook designed for modern school curricula.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 3499.99m,
                    SellingPrice = 1799.99m,
                    ImageUrl = "https://ibb.co/QFmGNjR"
                },
                //Novels
                new BookForSale
                {
                    BookForSaleId = "f1af480b-44a0-48d1-a20d-d2e1b3bd46d4",
                    BookName = "Democracy and Education",
                    BookDescription = "Embark on a riveting journey through the intricate interplay of democracy and education, where societal ideals clash and harmonize.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 8000.00m,
                    SellingPrice = 2000.00m,
                    ImageUrl = "https://ibb.co/7Vb2yM0"
                },

                new BookForSale
                {
                    BookForSaleId = "418f2b38-ae9e-49a8-9a8d-2ee99c8355cc",
                    BookName = "Because of a Teacher",
                    BookDescription = "A heartwarming novel that unfolds the transformative impact of a dedicated teacher on the lives of students, inspiring them to overcome challenges and achieve greatness.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 9000.00m,
                    SellingPrice = 4000.00m,
                    ImageUrl = "https://ibb.co/NTWqctd"
                },

                new BookForSale
                {
                    BookForSaleId = "a5454a2a-6e34-4a35-8e54-8789ee849c4b",
                    BookName = "Creating Innovators",
                    BookDescription = "Immerse yourself in a captivating tale that explores the birth of innovators, tracing their journeys through challenges, creativity, and the relentless pursuit of groundbreaking ideas.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 2499.99m,
                    SellingPrice = 1299.99m,
                    ImageUrl = "https://ibb.co/PQTcDJv"
                },

                new BookForSale
                {
                    BookForSaleId = "64a4c5a1-7782-4b4e-90b2-704dcd9d8d24",
                    BookName = "Lord of the Flies",
                    BookDescription = "Experience the gripping narrative of a group of stranded boys on a deserted island, as they grapple with power dynamics, morality, and the primal instincts that emerge in their struggle for survival.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 5999.99m,
                    SellingPrice = 2999.99m,
                    ImageUrl = "https://ibb.co/NTPFxRr"
                },

                new BookForSale
                {
                    BookForSaleId = "2f19959b-458f-42f8-927d-45ad1d66a2d8",
                    BookName = "How the Other Half Learns",
                    BookDescription = "Step into the intriguing world of education, where societal norms and disparities come to light, shaping the experiences of learners from different walks of life.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 2999.99m,
                    SellingPrice = 1499.99m,
                    ImageUrl = "https://ibb.co/mvpjYLb"
                },

                new BookForSale
                {
                    BookForSaleId = "878a3464-58b1-49b4-bdc3-ea201b6ac6ae",
                    BookName = "My Education",
                    BookDescription = "Embark on a literary journey that explores the intricacies of personal and academic growth, as characters navigate the challenges of self-discovery within the realm of education.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 3499.99m,
                    SellingPrice = 1999.99m,
                    ImageUrl = "https://ibb.co/TgzzWF3"
                },

                new BookForSale
                {
                    BookForSaleId = "3b1cc8f3-69e2-4ec0-8522-2c4e01b529c2",
                    BookName = "The Last Graduate",
                    BookDescription = "Dive into a thought-provoking narrative that envisions the future of education, its transformative power, and the impact it leaves on the last generation of graduates in a changing world.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 3999.99m,
                    SellingPrice = 2499.99m,
                    ImageUrl = "https://ibb.co/tKhXZVh"
                },

                new BookForSale
                {
                    BookForSaleId = "aa12e4eb-40a8-4cd8-837d-3dd207f56b97",
                    BookName = "Small Teaching",
                    BookDescription = "Experience the enchanting tale of a journey through science and technology, where small yet impactful teaching methods lead to profound discoveries and innovations.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 4499.99m,
                    SellingPrice = 2999.99m,
                    ImageUrl = "https://ibb.co/1XQJC2M"
                },

                new BookForSale
                {
                    BookForSaleId = "1a4ee5f0-0eab-4fe5-97e3-b0485c17384a",
                    BookName = "Laddering Your Success",
                    BookDescription = "Embark on a captivating exploration of general educational studies, where the ladder to success is built with knowledge, insights, and a comprehensive understanding of key concepts.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 3999.99m,
                    SellingPrice = 1999.99m,
                    ImageUrl = "https://ibb.co/NZstpRt"
                },

                new BookForSale
                {
                    BookForSaleId = "b79b1c76-1fb0-4a44-a758-0b6e524f245b",
                    BookName = "The Mirror and the Lamp",
                    BookDescription = "Delve into the enthralling narrative of academic disciplines intersecting within the realm of education, symbolized by the reflective 'Mirror' and the illuminating 'Lamp' guiding the way.",
                    BookCategory = BookCategory.Novel,
                    MarketPrice = 3499.99m,
                    SellingPrice = 1799.99m,
                    ImageUrl = "https://ibb.co/vz6pGWg"
                },
                //Journals
                new BookForSale
                {
                    BookForSaleId = "d0cde2d1-e9f7-4b1a-8a84-04ee55fb4a7e",
                    BookName = "Short Articles for Reading Comprehension",
                    BookDescription = "A collection of short articles designed to enhance reading comprehension skills.",
                    BookCategory = BookCategory.Article,
                    MarketPrice = 8000.00m,
                    SellingPrice = 2000.00m,
                    ImageUrl = "https://ibb.co/x35LZ3s"
                },

                new BookForSale
                {
                    BookForSaleId = "4f33e4a3-2cb2-4ef9-9839-862fc58f64cd",
                    BookName = "International Student Employability",
                    BookDescription = "Understanding business concepts and strategies for enhancing international student employability.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 9000.00m,
                    SellingPrice = 4000.00m,
                    ImageUrl = "https://ibb.co/s2pTv7W"
                },

                new BookForSale
                {
                    BookForSaleId = "7e4ed35f-e1a5-4a2a-baad-b6a6a2a8b5bb",
                    BookName = "Business Education Journal",
                    BookDescription = "An insightful journal exploring the intersection of business and education.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 2499.99m,
                    SellingPrice = 1299.99m,
                    ImageUrl = "https://ibb.co/wKk93Fq"
                },

                new BookForSale
                {
                    BookForSaleId = "f78b929f-71cc-4fb2-b0d8-3188194c73f3",
                    BookName = "Online Teaching and Learning in Higher Education during Covid-19",
                    BookDescription = "A guide to navigating online teaching and learning challenges during the Covid-19 pandemic.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 5999.99m,
                    SellingPrice = 2999.99m,
                    ImageUrl = "https://ibb.co/N97d49F"
                },

                new BookForSale
                {
                    BookForSaleId = "4b2c2c2c-3888-4214-9a3a-fa3075b9a373",
                    BookName = "Impact",
                    BookDescription = "Exploring the profound impact of global historical events on society.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 2999.99m,
                    SellingPrice = 1499.99m,
                    ImageUrl = "https://ibb.co/WvtS13k"
                },

                new BookForSale
                {
                    BookForSaleId = "e4d9c0b1-7c6c-4eb1-9f5d-7c0195d2bf88",
                    BookName = "504 Absolutely Essential Words",
                    BookDescription = "Mastering essential words to enhance vocabulary and language skills.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 3499.99m,
                    SellingPrice = 1999.99m,
                    ImageUrl = "https://ibb.co/PFMYxSn"
                },

                new BookForSale
                {
                    BookForSaleId = "0f8b75ef-5795-4f04-843a-7feae7661f01",
                    BookName = "Journal of Development and Innovation",
                    BookDescription = "Exploring innovative approaches to development in various fields.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 3999.99m,
                    SellingPrice = 2499.99m,
                    ImageUrl = "https://ibb.co/Z6zLqwD"
                },

                new BookForSale
                {
                    BookForSaleId = "5f68d2e2-7ce6-4310-bd29-9a46e5b60949",
                    BookName = "Research in Science and Technological Education",
                    BookDescription = "In-depth study of science and technology principles.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 4499.99m,
                    SellingPrice = 2999.99m,
                    ImageUrl = "https://ibb.co/DWT5wQm"
                },

                new BookForSale
                {
                    BookForSaleId = "6e6de32d-0682-4f5a-96d4-96c2f77f8f98",
                    BookName = "Educational Studies",
                    BookDescription = "Comprehensive guide to general educational studies and their concepts.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 3999.99m,
                    SellingPrice = 1999.99m,
                    ImageUrl = "https://ibb.co/8YQLsfx"
                },

                new BookForSale
                {
                    BookForSaleId = "c45330b1-d6b3-4a7a-8f92-4f33a11b3195",
                    BookName = "Journal of Interdisciplinary Studies in Education",
                    BookDescription = "Explore the dynamic intersection of various academic disciplines within the realm of education.",
                    BookCategory = BookCategory.TextBook,
                    MarketPrice = 3499.99m,
                    SellingPrice = 1799.99m,
                    ImageUrl = "https://ibb.co/SmJkzYp"
                }


            /* new BookForSale
             {
                 BookForSaleId = "25a9cfcc-24c3-4fe4-83ef-6f82e8704b4e",
                 BookName = "Introduction to Economics",
                 BookDescription = "Economics textbook",
                 Author = "John Doe",
                 EducationLevel = EducationLevel.SS1,
                *//* BookCategory = BookCategory.Science,*//*
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
             }*/
            );
        }
    }
}
