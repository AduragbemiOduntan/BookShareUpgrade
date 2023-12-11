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
        [Required(ErrorMessage = "First name is required field")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Name is 20 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(20,ErrorMessage = "Maximum length for the Name is 20 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 alphanumeric")]
        public string Password { get; set; }
        [Range(0,2,ErrorMessage ="Must be in range 0-2")]
        public UserType UserType { get; set; }
        public string? CompanyName { get; set; }//Transporter only
        public string? PhoneNumber { get; set; }//Transporter only
    }
}
