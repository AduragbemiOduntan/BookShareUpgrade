using System.ComponentModel.DataAnnotations.Schema;

namespace BookShare.Common.Dto.Request
{
    public record CreateRequestDto
    {
        public bool IsPickUp {  get; init; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LocationId { get; init; } //required
        public List<string> BooksId { get; init; } //required
    }
}
