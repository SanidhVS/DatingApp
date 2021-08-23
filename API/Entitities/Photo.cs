using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entitities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; } //Photo ID
        public string Url { get; set; } //Photo URL
        public bool IsMain { get; set; } //To check if its the main picture of the user
        public string PublicId { get; set; } //For setting up the public Id
        public AppUser AppUser { get; set; } //Refrencing AppUser to establish a nullable FK relationship
        public int AppUserId { get; set; } //This will be the FK
    }
}