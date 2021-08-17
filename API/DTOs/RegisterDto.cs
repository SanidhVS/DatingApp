using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] //Used for validation
        public string  Username { get; set; } //For setting up the username in DTO

        [Required] //Used for validation
        [StringLength(8 , MinimumLength = 4)]
        public string Password { get; set; } //For setting up the password in DTO
    }
}
