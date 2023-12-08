using BookShare.Common.Enum;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace BookShare.Common.Dto.Request
{
    public class TransporterRequestDto
    {
        public string UserId { get; set; }
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Logo URL is required")]
        [Url(ErrorMessage = "Invalid Logo URL")]
        public string LogoUrl { get; set; }
    }
}