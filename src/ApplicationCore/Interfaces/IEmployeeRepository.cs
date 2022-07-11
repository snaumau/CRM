using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IEmployeeRepository
    {
        public IQueryable<Employee> Employees { get; }
    }
}
