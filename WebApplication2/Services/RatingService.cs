using Models;
using Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class RatingService
    {
        public static IEnumerable<Rating> GetAll()
        {
            return RatingsRepository.GetAll();
        }

        public static Rating Get(int id)
        {
            var ratings = RatingsRepository.GetAll();
            return ratings.FirstOrDefault(x => x.Id == id);
        }
    }
}
