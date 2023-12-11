using System.ComponentModel.DataAnnotations;

namespace BookShare.Common.Dto.Request
{
    public class TransporterRequestDto
    {
        [Required(ErrorMessage = "User Id is Required")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Company name is required")]
        public string CompanyName { get; set; }
        
        [Required(ErrorMessage = "Phone Number is required")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Location Id is Required")]
        public string? LocationId { get; set; }
        [Required(ErrorMessage = "Logo URL is required")]
        [Url(ErrorMessage = "Invalid Logo URL")]
        public string LogoUrl { get; set; }
    }
}