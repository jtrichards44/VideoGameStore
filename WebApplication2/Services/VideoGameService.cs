using Final.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class VideoGameService
    {
        public static IEnumerable<VideoGame> GetVideoGameByName(string name)//return ienumerables with entity framework
        {
            if(string.IsNullOrEmpty(name))
            {
                return GetAll();
            }

            return GetAll().Where(x => x.Name.ToLower().Contains(name.ToLower()));//if the game name (lowercased) contains the search string (lowercased), then return that game
        }

        private static IEnumerable<VideoGame> GetAll()
        {
            var vg = new VideoGame
            {
                Description = "test game 1",
                ReleasedDate = System.DateTime.Now,
                Rented = false,
                UPC = "sterserfdasr",
                Name = "God of War",
                RatingId = 1,
                PlatformId = 1
            };

            var vg2 = new VideoGame
            {
                Description = "test game 2",
                ReleasedDate = System.DateTime.Now,
                Rented = true,
                UPC = "sterserfdasdfasdfsr",
                Name = "God of War 2",
                RatingId = 2,
                PlatformId = 2
            };

            return new List<VideoGame> { vg, vg2 };
        }
    }
}
