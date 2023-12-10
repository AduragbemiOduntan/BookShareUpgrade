using System.ComponentModel.DataAnnotations.Schema;

namespace BookShare.Common.Dto.Request
{
    public record CreateRequestDto
    {
        public bool IsPickUp {  get; init; }
        public string LocationId { get; init; } //required
        public List<string> BooksId { get; init; } //required
    }
}
