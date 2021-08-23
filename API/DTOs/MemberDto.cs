using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; } //For setting up the id of the user
        public string Username { get; set; } //For setting up the username of the user
        public string PhotoUrl { get; set; } //For setting up Photo url
        public int Age { get; set; } //User Age
        public string KnownAs { get; set; } // User Nickname
        public DateTime Created { get; set; } //To get created date
        public DateTime LastActive { get; set; } // To get last active status
        public string Gender { get; set; } //Gender of the user
        public string Introduction { get; set; } //For intoduction paragraphs
        public string LookingFor { get; set; } //For the interests user is looking for
        public string Interests { get; set; } //For the interests of user like hobbies
        public string City { get; set; } //For city of the user
        public string Country { get; set; } //For the country User lives in
        public ICollection<PhotoDto> Photos { get; set; } //For the user photos
    }
}
