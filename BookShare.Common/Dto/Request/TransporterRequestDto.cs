using BookShare.Common.Enum;

namespace BookShare.Common.Dto.Request
{
    public class TransporterRequestDto
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public DocumentType DocumentType { get; set; }
        public string LogoUrl { get; set; }
        public string locationId { get; set; }
    }
}