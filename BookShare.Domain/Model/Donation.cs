using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Model
{
    public class Donation
    {
        public string DonationId { get; set; } = Guid.NewGuid().ToString();
        public string BookCondition { get; set; }
        public int NumberOfBoxes { get; set; }
        public DateTime DonationDate { get; set; }
        public string UserId { get; set; }
        public bool IsDelivered { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPickUp { get; set; }
        public string LocationId { get; set; }
        public string PhoneNumber { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
    }
}
