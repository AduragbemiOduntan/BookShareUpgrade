using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Request
{
    public record UserCreateRequestDto
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string IsVerified { get; set; }
    }
}
