using System;

namespace WebApplication2.ViewModels
{
    public class NewVideoGameViewModel
    {
        public string VideoGameName { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string Description { get; set; }
        public bool Rented { get; set; }
        public string UPC { get; set; }

        public int SelectedPlatformId { get; set; }
        public int SelectedRatingId { get; set; }
    }
}