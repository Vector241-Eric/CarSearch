using System.Web.Mvc;

namespace CarSearch.Controllers
{
    public class HomeController : Controller
    {
         public ActionResult Index()
         {
             return View();
         }
    }
}