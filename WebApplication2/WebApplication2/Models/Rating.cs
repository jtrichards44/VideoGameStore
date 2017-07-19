namespace WebApplcation2.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum RatingIds
    {
        Everyone = 1,
        Teen,
        Mature
    }
}
