using Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class RatingService
    {
        public static IEnumerable<Rating> GetAll()
        {
            return MockDB();
        }

        public static Rating Get(int id)
        {
            var ratings = MockDB();
            return ratings.FirstOrDefault(x => x.Id == id);
        }

        public static IEnumerable<Rating> MockDB()
        {
            var platforms = new List<Rating>();
            platforms.Add(new Rating { Id = 1, Name = "T" });
            platforms.Add(new Rating { Id = 2, Name = "E" });

            return ratings;
        }
    }
}
