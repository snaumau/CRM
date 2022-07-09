using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcom!\nThis page in development.";
        }
    }
}
