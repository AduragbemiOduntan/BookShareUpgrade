using BookShare.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Response
{
    public class UserResponseDto
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string IsVerified { get; set; }
        public UserType UserType { get; set; }
        public string TransportId { get; set; }
        public string KycId { get; set; }
    }
}
