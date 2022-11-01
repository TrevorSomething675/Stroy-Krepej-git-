using Microsoft.AspNetCore.Mvc;
using Stroy_krepej.Domain;

namespace Stroy_krepej.Areas.Jijahiha.Controllers
{
    [Area("Jijahiha")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
