using Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class PlatformService
    {
        public static IEnumerable<Platform> GetAll()
        {
            return MockDB();
        }

        public static Models.Platform Get(int id)
        {
            var platforms = MockDB();
            return platforms.FirstOrDefault(x => x.Id == id);
        }

        public static IEnumerable<Platform> MockDB()
        {
            var platforms = new List<Platform>();
            platforms.Add(new Platform { Id = 1, Name = "Playstation" });
            platforms.Add(new Platform { Id = 2, Name = "XBox" });

            return platforms;
        }
    }
}
