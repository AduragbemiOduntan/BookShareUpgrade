using BookShare.Common.Enum;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShare.Domain.Model
{
    public class User : IdentityUser //--> Should we merge Transporter and KYC into User ??
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string IsVerified { get; set; }
        public UserType UserType { get; set; }
        [ForeignKey(nameof(Transporter))]
        public string TransportId { get; set; }
        public Transporter Transporter { get; set; }
        [ForeignKey(nameof(KYC))]
        public string KycId { get; set; }
        public KYC KYC { get; set; }

    }
}
