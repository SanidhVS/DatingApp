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
    }
}
