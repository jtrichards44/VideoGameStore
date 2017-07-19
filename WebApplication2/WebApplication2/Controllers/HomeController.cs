using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication2.ViewModels;
using Final.Models;
using System.Linq;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //get list of platforms from database
            var platforms = new List<Platform> {
                        new Platform { Id= 1, Name = "switch"},
                        new Platform { Id = 2, Name = "playstation"}
                    };

            var ratings = new List<Rating> { new Rating { Id = 1, Name = "E" }, new Rating { Id = 2, Name = "T" } };

            var ratingsSelectList = new SelectList(ratings, "Id", "Name");
            var platformSelectList = new SelectList(platforms, "Id", "Name");

            var nvgvm = new NewVideoGameViewModel {
                Description = "Test description 1", ReleasedDate = System.DateTime.Now, Rented = false, SelectedPlatform = null, SelectedRating = null, UPC = "sterserfdasr", VideoGameName = "test game 1", RatingOptions = ratingsSelectList, PlatformOptions = platformSelectList};

            var vm = new IndexViewModel { NewVideoGameViewModel = nvgvm };
            return View(vm);
        }
    }
}