using Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;

namespace Repositories
{
    public class VideoGamesRepository
    {
        public static IEnumerable<VideoGame> GetAll()
        {
            var videoGames = new List<VideoGame>();

            using (var context = new VideoGameStoreEntities())
            {
                videoGames.AddRange(context.VideoGames.ToList());
            }

            return videoGames;
        }

        public static void AddOrUpdate(VideoGame game)
        {
            using (var context = new VideoGameStoreEntities())
            {
                var vg = context.VideoGames.FirstOrDefault(x => x.Name.ToLower() == game.Name.ToLower());

                if (vg == null)
                {
                    game.Id = GetAll().Max(x => x.Id) + 1;
                    context.VideoGames.Add(game);
                }

                else
                {
                    vg.Description = game.Description;
                    vg.Name = game.Name;
                    vg.PlatformId = game.PlatformId;
                    vg.RatingId = game.RatingId;
                    vg.Rented = game.Rented;
                    vg.UPC = game.UPC;
                    vg.ReleasedDate = game.ReleasedDate;

                    context.VideoGames.AddOrUpdate(vg);
                }

                context.SaveChanges();
            }
        }

        public static void Delete(VideoGame game)
        {
            using (var context = new VideoGameStoreEntities())
            {
                context.VideoGames.Remove(context.VideoGames.First(x=>x.Id == game.Id));
                context.SaveChanges();
            }
        }
    }
}
