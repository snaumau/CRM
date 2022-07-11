using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Components
{
    public class DarkstoreMenu : ViewComponent
    {
        private readonly IDarkstoreRepository? _darkstoreRepository;

        public DarkstoreMenu(IDarkstoreRepository? darkstoreRepository)
        {
            _darkstoreRepository = darkstoreRepository;
        }

        public IViewComponentResult Invoke()
        {
            var darkstores = _darkstoreRepository?.AllDarkstores?
                .OrderBy(d => d.DarkstoreId);
            return View(darkstores);
        }
    }
}
