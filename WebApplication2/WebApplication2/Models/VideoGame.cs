using System;

namespace WebApplcation2.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string Description { get; set; }
        public bool Rented { get; set; }
        public string UPC { get; set; }

        public int PlatformId { get; set; }
        public int RatingId { get; set; }
    }
}