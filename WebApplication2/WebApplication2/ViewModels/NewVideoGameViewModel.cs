using System;
using System.Web.Mvc;

namespace WebApplication2.ViewModels
{
    public class NewVideoGameViewModel
    {
        public string VideoGameName { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string Description { get; set; }
        public bool Rented { get; set; }
        public string UPC { get; set; }

        public SelectListItem SelectedPlatform { get; set; }
        public SelectListItem SelectedRating { get; set; }

        public SelectList PlatformOptions { get; set; }
        public SelectList RatingOptions { get; set; }
    }
}