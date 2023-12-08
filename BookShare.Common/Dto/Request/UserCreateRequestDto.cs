using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Request
{
    public record UserCreateRequestDto
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        public string FirstName{ get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        public string LastName{ get; set; }

        [Required(ErrorMessage = "Image URL is required")]
        [Url(ErrorMessage = "Invalid image URL")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "IsVerified field is required")]
        [RegularExpression(@"^(True|False)$", ErrorMessage = "IsVerified must be True or False")]
        public string IsVerified { get; set; }
    }
}
