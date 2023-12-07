using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Model
{
    public class Location : BaseEntity
    {
        public string LocationId { get; set; } = Guid.NewGuid().ToString();
        public string State { get; set; }
        public string City { get; set; }
        public string LGA { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
    }
}
