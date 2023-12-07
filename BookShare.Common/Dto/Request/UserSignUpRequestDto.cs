using BookShare.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Request
{
    public record UserSignUpRequestDto
    {
        [Required(ErrorMessage ="First name is required")]
        public required string FirstName { get; set; }
        [Required(ErrorMessage ="Last name is required")]
        public required string LastName { get; set; }
        [EmailAddress(ErrorMessage ="Email address is invalid")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Range(0,2,ErrorMessage ="Must be in range 0-2")]
        public UserType UserType { get; set; }
    }
}
