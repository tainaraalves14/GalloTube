using System.ComponentModel.DataAnnotations.Schema;

namespace GalloTube.Models
{
    public class VideoTag
    {
        public int Id { get; set; }

        [ForeignKey("Video")]
        public int VideoId { get; set; }
        public Video Video { get; set; }

        [ForeignKey("Tag")]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
