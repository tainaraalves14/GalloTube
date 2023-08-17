using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GalloTube.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(200)]
        public string ProfilePicture { get; set; }
    }
}
