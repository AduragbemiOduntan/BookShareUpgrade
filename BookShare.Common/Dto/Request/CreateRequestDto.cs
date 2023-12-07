using System.ComponentModel.DataAnnotations.Schema;

namespace BookShare.Common.Dto.Request
{
    public record CreateRequestDto
    {
        public string UserId { get; init; }
        public string LocationId { get; init; }
        public List<string> BooksId { get; init; }
    }
}
