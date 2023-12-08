using BookShare.Common.Enum;

namespace BookShare.Common.Dto.Request
{
    public class TransporterRequestDto
    {
        public string UserId { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string LogoUrl { get; set; }
    }
}