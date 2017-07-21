using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class VideoGameController : Controller
    {
        [HttpPost]
        public ActionResult AddOrUpdate(NewVideoGameViewModel vm)
        {
            VideoGameService.AddNewGameOrUpdate(new VideoGame {Description = vm.Description, Name = vm.VideoGameName, PlatformId = vm.SelectedPlatformId, RatingId = vm.SelectedRatingId, ReleasedDate = (vm.ReleasedDate ?? DateTime.Now), Rented = vm.Rented, UPC = vm.UPC  });

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public JsonResult Search(string searchString)
        {
            var vms = new List<VideoGameViewModel>();

            var foundGames = VideoGameService.GetVideoGameByName(searchString);
            foreach(var game in foundGames)
            {
                var vm = new VideoGameViewModel(game);
                vm.PlatformName = PlatformService.Get(game.PlatformId).Name;
                vm.RatingName = RatingService.Get(game.RatingId).Name;
                vms.Add(vm);
            }

            return Json(vms, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void ChangeStatusOfRentals(List<VideoGame> games)
        {
            VideoGameService.SaveRentalBroughtBacks(games);
        }


        [HttpPost]
        public void DeleteVideoGames(List<int> ids)
        {
            VideoGameService.DeleteVideoGames(ids);
        }
    }
}