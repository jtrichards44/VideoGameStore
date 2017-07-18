using System.Web.Mvc;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new NewVideoGameViewModel();
            return View(vm);
        }
    }
}