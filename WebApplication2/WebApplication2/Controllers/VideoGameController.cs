using Services;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class VideoGameController : Controller
    {
        [HttpGet]
        public JsonResult Search(string searchString)
        {
            var foundGames = VideoGameService.GetVideoGameByName(searchString);
            return Json(foundGames, JsonRequestBehavior.AllowGet);
        }
    }
}