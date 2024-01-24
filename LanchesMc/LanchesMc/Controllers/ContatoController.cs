using Microsoft.AspNetCore.Mvc;

namespace LanchesMc.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
				return View();
			}
            return RedirectToAction("Login", "Account");
        }
    }
}
