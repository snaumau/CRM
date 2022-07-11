using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee { Id = 1, FirstName = "Homer", LastName = "Simpson", Position = "courier", AccountNumber = "00000001", DarkstoreId = 1 },
                new Employee { Id = 2, FirstName = "Marge", LastName = "Simpson", Position = "picker", AccountNumber = "00000002", DarkstoreId = 1 },
                new Employee { Id = 3, FirstName = "Bart", LastName = "Simpson", Position = "courier", AccountNumber = "00000003", DarkstoreId = 1 },
                new Employee { Id = 4, FirstName = "Philip", LastName = "Fry", Position = "courier", AccountNumber = "00000004", DarkstoreId = 2 },
                new Employee { Id = 5, FirstName = "Farnsworth", LastName = "Professor", Position = "courier", AccountNumber = "00000005", DarkstoreId = 2 },
                new Employee { Id = 6, FirstName = "Leela", LastName = "Turanga", Position = "picker", AccountNumber = "00000006", DarkstoreId = 2 },
                new Employee { Id = 7, FirstName = "Stan", LastName = "Smith", Position = "picker", AccountNumber = "00000007", DarkstoreId = 3 },
                new Employee { Id = 8, FirstName = "Steve", LastName = "Smith", Position = "courier", AccountNumber = "00000008", DarkstoreId = 3 },
                new Employee { Id = 9, FirstName = "Roger", LastName = "Smith", Position = "courier", AccountNumber = "00000003", DarkstoreId = 3 });
        }
    }
}
