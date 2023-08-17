using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GalloTube.Models
{
    public class Tag
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        
    }
}



