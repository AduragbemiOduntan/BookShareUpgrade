using BookShare.Common.Enum;
using System.ComponentModel.DataAnnotations;

namespace BookShare.Common.Dto.Request
{
    public class BookRequestDto
    {
        [Required(ErrorMessage = "Book name is required")]
        public string BookName{ get; set; }
        [Required(ErrorMessage = "Author name is required")]
        public string Author{ get; set; }
        [StringLength(100, ErrorMessage = "Publisher name cannot exceed 50 characters")]
        public string? BookDescription { get; set; }
        public string? Publisher { get; set; }
        [Required(ErrorMessage = "Education level is required")]
        public EducationLevel? EducationLevel { get; set; }
        [Required(ErrorMessage = "Book category is required")]
        public BookCategory? BookCategory { get; set; }
        [Required(ErrorMessage = "Subject is required")]
        public Subject Subject { get; set; }
        public string? UserId { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Market price must be greater than zero")]
        public decimal MarketPrice { get; set; }
   /*     [Range(0.01, double.MaxValue, ErrorMessage = "Selling price must be greater than zero")]*/
        public decimal SellingPrice { get; set; }
        [DataType(DataType.Date), Required(ErrorMessage = "Listed date is required")]
        public BookCondition BookCondition { get; set; }
        [MaxLength(200, ErrorMessage = "Image URL cannot exceed 200 characters")]
        public string? ImageUrl { get; set; }
/*        [MaxLength(13, ErrorMessage = "ISBN cannot exceed 13 characters")]
        public string? ISBN { get; set; }*/
        [Required(ErrorMessage = "Listing type is required")]
        public ListingType ListingType { get; set; }
    }
}
