using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GalloTube.Models
{
    public class VideoTag
    {
        public int VideoId { get; set; }

        public int TagId { get; set; }

    }
}
