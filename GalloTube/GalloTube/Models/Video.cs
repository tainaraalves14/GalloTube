using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GalloTube.Models
{
    public class Video
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(8000)]
        public string Description { get; set; }

        public DateTime UploadDate { get; set; }

        [Required]
        [StringLength(16)]
        public int Duration { get; set; }

        [Required]
        [StringLength(200)]
        public int Thumbnail { get; set; }

        [Required]
        [StringLength(200)]

        public string VideoFile { get; set; }
       
        
    }
}
