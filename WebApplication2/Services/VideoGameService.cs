using System.Collections.Generic;
using System.Linq;
using System;
using Models;
using Repositories;

namespace Services
{
    public class VideoGameService
    {
        public static IEnumerable<VideoGame> GetVideoGameByName(string name)//return ienumerables with entity framework
        {
            if(string.IsNullOrEmpty(name))
            {
                return GetAll().ToList();
            }

            return GetAll().Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();//if the game name (lowercased) contains the search string (lowercased), then return that game
        }

        public static void AddNewGameOrUpdate(VideoGame videoGame)
        {
            VideoGamesRepository.AddOrUpdate(videoGame);
        }

        public static void SaveRentalBroughtBacks(IList<VideoGame> games)
        {
            foreach(var game in games)
            {
                var gameFromRepo = GetAll().FirstOrDefault(x=>x.Id == game.Id);
                gameFromRepo.Rented = game.Rented;
                VideoGamesRepository.AddOrUpdate(gameFromRepo);
            }
        }

        public static void DeleteVideoGames(IList<int> ids)
        {
            foreach(var id in ids)
            {
                var gameToDelete = GetAll().FirstOrDefault(x => x.Id == id);
                VideoGamesRepository.Delete(gameToDelete);
            }
        }

        private static IEnumerable<VideoGame> GetAll()
        {
            return VideoGamesRepository.GetAll();
        }

    }
}
