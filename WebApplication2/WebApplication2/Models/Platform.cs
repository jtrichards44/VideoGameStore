using System.Collections.Generic;

namespace Final.Models
{
    public class Platform
    {
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
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
