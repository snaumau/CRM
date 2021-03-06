using ApplicationCore.Entities;

namespace Web.ViewModels
{
    public class EmployeeListViewModel
    {
        public IQueryable<Employee>? Employees { get; set; }
        public string? CurrentDarkstore { get; set; }
    }
}
