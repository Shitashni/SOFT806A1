
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HandicraftStore.Data
{
    public class ApplicationUser : IdentityUser
    {
        public  string FirstName { get; set; } 
        public string LastName { get; set; }

    }
}
