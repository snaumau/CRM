using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDarkstoreRepository _darkstoreRepository;

        public EmployeeController(IEmployeeRepository employeeRepository, IDarkstoreRepository darkstoreRepository)
        {
            _employeeRepository = employeeRepository;
            _darkstoreRepository = darkstoreRepository;
        }

        public ViewResult List(string darkstore)
        {
            IQueryable<Employee>? employees;
            string? currentDarkstore;
            if (string.IsNullOrEmpty(darkstore))
            {
                employees = _employeeRepository.Employees?
                    .OrderBy(d => d.Id);
                currentDarkstore = "AllDarkstores";
            }
            else
            {
                employees = _employeeRepository.Employees?
                    .Where(e => e.Darkstore.Name == darkstore)
                    .OrderBy(e => e.Id);
                currentDarkstore = _darkstoreRepository.AllDarkstores?
                    .FirstOrDefault(d => d.Name == darkstore)?.Name;
            }

            return View(new EmployeeListViewModel
            {
                Employees = employees,
                CurrentDarkstore = currentDarkstore,
            });
        }
    }
}
