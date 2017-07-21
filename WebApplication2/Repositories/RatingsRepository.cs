using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class RatingsRepository
    {
        public static IEnumerable<Rating> GetAll()
        {
            var ratings = new List<Rating>();

            using (var context = new VideoGameStoreEntities())
            {
                ratings.AddRange(context.Ratings.ToList());
            }

            return ratings;
        }
    }
}
