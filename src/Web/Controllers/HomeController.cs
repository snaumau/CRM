using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDarkstoreRepository _darkstoreRepository;

        public HomeController(IDarkstoreRepository darkstoreRepository)
        {
            _darkstoreRepository = darkstoreRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                AllDarkstores = _darkstoreRepository.AllDarkstores,
            };
            return View(homeViewModel);
        }
    }
}
