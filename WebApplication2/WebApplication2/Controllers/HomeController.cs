using Models;
using Services;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //get list of platforms from database
            var platforms = PlatformService.GetAll();
            var ratings = RatingService.GetAll();


            var ratingsSelectList = new SelectList(ratings, "Id", "Name");
            var platformSelectList = new SelectList(platforms, "Id", "Name");

            var vm = new NewVideoGameViewModel {RatingOptions = ratingsSelectList, PlatformOptions = platformSelectList};

            return View(vm);
        }
    }
}