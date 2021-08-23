using API.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entitities
{
    public class AppUser
    {
        public int Id { get; set; } //For setting up the id of the user
        public string UserName { get; set; } //For setting up the username of the user

        public byte[] PasswordHash { get; set; } //For setting up password hash in DB

        public byte[] PasswordSalt { get; set; } //For setting up password Salt in DB

        public DateTime DateOfBirth { get; set; } //User DOB
        public string KnownAs { get; set; } // User Nickname
        public DateTime Created { get; set; } = DateTime.Now; //To get created date
        public DateTime LastActive { get; set; } = DateTime.Now; // To get last active status
        public string Gender { get; set; } //Gender of the user
        public string Introduction { get; set; } //For intoduction paragraphs
        public string LookingFor { get; set; } //For the interests user is looking for
        public string Interests { get; set; } //For the interests of user like hobbies
        public string City { get; set; } //For city of the user
        public string Country { get; set; } //For the country User lives in
        public ICollection<Photo> Photos { get; set; } //For the user photos

        //public int GetAge() {
        //    return DateOfBirth.CalculateAge();
        
        //}
    }
}
