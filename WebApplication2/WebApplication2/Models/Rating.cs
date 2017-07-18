namespace Final.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public string RatingName { get; set; }
    }

    public enum RatingIds
    {
        Everyone = 1,
        Teen,
        Mature
    }
}
