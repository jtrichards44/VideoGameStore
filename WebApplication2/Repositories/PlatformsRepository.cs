using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class PlatformsRepository
    {
        public static IEnumerable<Platform> GetAll()
        {
            var platforms = new List<Platform>();

            using(var context = new VideoGameStoreEntities())
            {
                platforms.AddRange(context.Platforms.ToList());
            }

            return platforms;
        }
    }
}
