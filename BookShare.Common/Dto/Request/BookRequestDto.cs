using BookShare.Common.Enum;

namespace BookShare.Common.Dto.Request
{
    public class BookRequestDto
    {
        public string BookName { get; set; }
        public string? BookDescription { get; set; }
        public string Author { get; set; }
        public string? Publisher { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public BookCategory BookCategory { get; set; }
        public Subject Subject { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public BookCondition BookCondition { get; set; }
        public string? ImageUrl { get; set; }
        public string? ISBN { get; set; }
        public ListingType ListingType { get; set; }
    }
}
