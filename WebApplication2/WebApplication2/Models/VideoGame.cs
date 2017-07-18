using System;

namespace Final.Models
{
    public class VideoGame
    {
        public int VideoGameId { get; set; }
        public string VideoGameName { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string Description { get; set; }
        public bool Rented { get; set; }
        public string UPC { get; set; }

        public int PlatformId { get; set; }
        public int RatingId { get; set; }
    }
}