using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Response
{
    public record DeliveryDto
    {
        public string CreatorId { get; set; }
        public string RecipientName { get; set; }

        public decimal DeliveryPrice { get; set; }

        public string? ReceiverPhoneNumber { get; set; }
        public bool IsDelivered { get; set; }

        public string LocationId { get; set; }

        public string TransporterId { get; set; }

        public string UserId { get; set; }

        public string BookForSaleId { get; set; }
        //[Required(ErrorMessage = "Request ID is mandatory")]
        //public string? RequestId { get; set; }
    }
}
