using BookShare.Common.Enum;

namespace BookShare.Common.Dto.Request
{
    public class BookForSaleDto
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string? Publisher { get; set; }
        public EducationLevel? EducationLevel { get; set; }
        public BookCategory? BookCategory { get; set; }
        public Subject Subject { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime ListedDate { get; set; }
        public BookCondition BookCondition { get; set; }
        public string? ImageUrl { get; set; }
        public string? ISBN { get; set; }
        public ListingType? BookListing { get; set; }
    }
}
