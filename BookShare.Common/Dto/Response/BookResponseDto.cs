using BookShare.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Response
{
    public class BookResponseDto
    {
        public string BookName { get; set; }
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
        public ListingType ListingType { get; set; }
    }
}
