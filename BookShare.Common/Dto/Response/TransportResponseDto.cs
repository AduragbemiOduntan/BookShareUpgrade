using BookShare.Common.Enum;

namespace BookShare.Common.Dto.Response
{
    public class TransportResponseDto
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public DocumentType DocumentType { get; set; }
        public string LogoUrl { get; set; }
    }
}
