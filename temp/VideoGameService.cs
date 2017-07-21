using Services.Models;
using System.Collections.Generic;
using System.Linq;
using System;

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

        public static void SaveRentalBroughtBacks(IList<VideoGame> games)
        {
            foreach(var game in games)
            {
                //update existing game in db
            }
        }

        public static void DeleteVideoGames(IList<int> ids)
        {
            foreach(var id in ids)
            {
                //call delete function in EF
            }
        }

        private static IEnumerable<VideoGame> GetAll()
        {

            return new List<VideoGame> { vg, vg2 };
        }
    }
}
