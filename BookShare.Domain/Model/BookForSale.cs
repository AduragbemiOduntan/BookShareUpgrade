using BookShare.Common.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShare.Domain.Model
{
    public class BookForSale : BaseEntity
    {
        public string BookForSaleId { get; set; } = Guid.NewGuid().ToString();
        public string BookName { get; set; }
        public string Author { get; set; }
        public EducationLevel? EducationLevel { get; set; }
        public BookCategory? BookCategory { get; set; }
        public Subject Subject { get; set; }
        [Column(TypeName ="money")]
        public decimal MarketPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal SellingPrice { get; set; }
        public DateTime ListedDate { get; set; }
        public string BookCondition { get; set; }
        public bool IsSoldOut { get; set; }
        public string? ImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        [ForeignKey(nameof(Location))]
        public string LocationId { get; set; }
        public virtual Location? Location { get; set; }

    }
}
