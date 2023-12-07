using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Model
{
    public class Delivery : BaseEntity
    {
        public string DeliveryId { get; set; } = Guid.NewGuid().ToString();
        public string RecipientName { get; set;}
        public string TransporterId { get; set;}
        public string UserId { get; set;}
        public string? DonationId { get; set;}
        public string? RequestId { get; set;}
        public Transporter Transporter  { get; set;}
        public  User User { get; set;}
        public Donation Donation{ get; set;}
        public Request Request{ get; set;}
    }
}
