using BookShare.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Request
{
    public class BookUpdateRequestDto
    {
        [Required(ErrorMessage = "Book name is required")]
        public string BookName { get; set; }
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string? BookDescription { get; set; }
        public BookCategory? BookCategory { get; set; }
        [Column(TypeName = "money")]
        public decimal MarketPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? SellingPrice { get; set; }
        public string? ImageUrl { get; set; }
        public ListingType? ListingType { get; set; }
    }
}
