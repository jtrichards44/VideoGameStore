using Models;
using Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class PlatformService
    {
        public static IEnumerable<Platform> GetAll()
        {
            return PlatformsRepository.GetAll();
        }

        public static Models.Platform Get(int id)
        {
            var platforms = PlatformsRepository.GetAll();
            return platforms.FirstOrDefault(x => x.Id == id);
        }
    }
}
