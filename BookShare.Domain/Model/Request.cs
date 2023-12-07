using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Model
{
    public class Request : BaseEntity
    {
        public string RequestId { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; }
        public string BookId { get; set; }
        public string LocationId { get; set; }
        public bool IsReceived { get; set; }
        public bool IsPickUp { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
