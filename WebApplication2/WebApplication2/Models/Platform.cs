using System.Collections.Generic;

namespace WebApplcation2.Models
{
    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum PlatformIds
    {
        Switch = 1,
        WiiU,
        Wii,
        GameCube,
        N64,
        Playstation,
        Playstation2,
        Playstation3,
        Playstation4,
        Xbox,
        Xbox360,
        XboxOne,
        PC
    }
}
