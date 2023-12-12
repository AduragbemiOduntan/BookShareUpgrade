using System.ComponentModel.DataAnnotations.Schema;

namespace BookShare.Domain.Model;

public class Request : BaseEntity
{
    public string RequestId { get; set; } = Guid.NewGuid().ToString();
    public bool IsReceived { get; set; }
    public bool IsDelivered { get; set; }
    public bool IsPickUp { get; set; }
    //[ForeignKey(nameof(User))]
    public string? UserId { get; set; }
    public User? User { get; set; }
    //[ForeignKey(nameof(Location))]
    public string? LocationId { get; set; }
    public Location? Location { get; set; }
    public ICollection<BookForSale> Books { get; set; }
}
