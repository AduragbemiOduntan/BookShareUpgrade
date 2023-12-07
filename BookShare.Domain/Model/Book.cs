namespace BookShare.Domain.Model
{
    public class Book : BaseEntity
    {
        public string BookId { get; set; } = Guid.NewGuid().ToString();
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string EducationLevel { get; set; }
        public string BookCategory { get; set; }
        public string IsAvailable { get; set; }
        public string ImageUrl { get; set; }
        public string Quantity { get; set; }
        public Donation donationId { get; set; }
    }
}
