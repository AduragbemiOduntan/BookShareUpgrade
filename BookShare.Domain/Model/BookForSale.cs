using BookShare.Common.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShare.Domain.Model
{
    public class BookForSale : BaseEntity
    {
        public string BookForSaleId { get; set; } = Guid.NewGuid().ToString();
        public string BookName { get; set; }
        public string? BookDescription { get; set; }
        public DateTime BookCreationId { get; set; } = DateTime.Now;
        public BookCategory? BookCategory { get; set; }
        [Column(TypeName = "money")]
        public decimal MarketPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? SellingPrice { get; set; }
        public string? ImageUrl { get; set; }
        public ListingType? ListingType { get; set; }

        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public EducationLevel? EducationLevel { get; set; }
        public Subject? Subject { get; set; }
        public DateTime ListedDate { get; set; } = DateTime.Now;
        public BookCondition? BookCondition { get; set; }
        public bool? IsSoldOut { get; set; }
        public string? ISBN { get; set; }
        public bool? IsDisabled { get; set; } //Later add enum stating reason why book is diabled
        public byte? HarmfulContentCount { get; set; }
        /*public string PhoneNumber { get; set; }*///Why is this here?
        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }
        public virtual User? User { get; set; }
        [ForeignKey(nameof(Location))]
        public string? LocationId { get; set; }
        public virtual Location? Location { get; set; } // This is to know where the is available ie, state or LGA.
    }
}
