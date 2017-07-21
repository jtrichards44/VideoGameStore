using Models;

namespace WebApplication2.ViewModels
{
    public class VideoGameViewModel
    {
        public VideoGameViewModel(VideoGame vg)
        {
            Id = vg.Id;
            Name = vg.Name;
            ReleasedDate = vg.ReleasedDate;
            Description = vg.Description;
            Rented = vg.Rented;
            UPC = vg.UPC;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime ReleasedDate { get; set; }
        public string Description { get; set; }
        public bool Rented { get; set; }
        public string UPC { get; set; }
        public string PlatformName { get; set; }
        public string RatingName { get; set; }
    }
}