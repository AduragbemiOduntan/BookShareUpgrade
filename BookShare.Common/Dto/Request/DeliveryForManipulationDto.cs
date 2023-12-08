using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Request
{
    public abstract record DeliveryForManipulationDto
    {
        [Required(ErrorMessage = "Recipient Name is compulsory")]
        [MaxLength(20, ErrorMessage ="Recipient Name can not exceed 20 characters")]
        public string RecipientName { get; set; }
        [Column(TypeName = "money")]
        public decimal DeliveryPrice { get; set; }

        [Phone(ErrorMessage = "Valid phone number is expected")]
        [MaxLength(11, ErrorMessage = "Phone number can not exceed 11 digits")]
        public string? ReceiverPhoneNumber { get; set; }
        public bool IsDelivered { get; set; }
        [Required(ErrorMessage = "Location is mandatory")]
        public string LocationId { get; set; }
        [Required(ErrorMessage = "Transporter ID is mandatory")]
        public string TransporterId { get; set; }
        [Required(ErrorMessage = "Sender ID is mandatory")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Book ID is mandatory")]
        public string BookForSaleId { get; set; }
        [Required(ErrorMessage = "Request ID is mandatory")]
        public string? RequestId { get; set; }
    }
}
