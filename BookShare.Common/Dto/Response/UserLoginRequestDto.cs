using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Response
{
    public class UserLoginRequestDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
