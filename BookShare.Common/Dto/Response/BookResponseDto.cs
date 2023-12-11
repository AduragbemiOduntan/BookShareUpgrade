using BookShare.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Response
{
    public class BookResponseDto
    {
        public string BookForSaleId { get; set; } 
        [Required(ErrorMessage = "Book name is required")]
        public string BookName { get; set; }
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string? BookDescription { get; set; }
        public DateTime BookCreationId { get; set; } = DateTime.Now;
        public BookCategory? BookCategory { get; set; }
        [Column(TypeName = "money")]
        public decimal MarketPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? SellingPrice { get; set; }
        public string? ImageUrl { get; set; }
        public ListingType? ListingType { get; set; }
        /* public string BookName { get; set; }
         public string? BookDescription { get; set; }
         public string Author { get; set; }
         public string? Publisher { get; set; }
         public EducationLevel EducationLevel { get; set; }
         public BookCategory BookCategory { get; set; }
         public Subject? Subject { get; set; }
         public decimal MarketPrice { get; set; }
         public decimal? SellingPrice { get; set; }
         public BookCondition BookCondition { get; set; }
         public string? ImageUrl { get; set; }
         public string? ISBN { get; set; }
         public ListingType ListingType { get; set; }*/
    }
}
