using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Model
{
    public class Delivery : BaseEntity
    {
        public string DeliveryId { get; set; } = Guid.NewGuid().ToString();
        public string RecipientName { get; set;}
        [Column(TypeName = "money")]
        public decimal DeliveryPrice { get; set; }
        public string? ReceiverPhoneNumber { get; set; }
        public bool IsDelivered { get; set; }
        [ForeignKey(nameof(Location))]
        public string LocationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey(nameof(Transporter))]
        public string TransporterId { get; set;}
        public Transporter Transporter  { get; set;}
        [ForeignKey(nameof(User))]
        public string UserId { get; set;}
        public  User User { get; set;}
        [ForeignKey(nameof(BookForSale))]
        public string BookForSaleId { get; set; }
        public BookForSale BookForSale{ get; set;}
        [ForeignKey(nameof(Request))]
        public string? RequestId { get; set;}
        public Request Request{ get; set;}
    }
}
