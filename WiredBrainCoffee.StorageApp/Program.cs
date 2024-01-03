using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            AddEmployees(employeeRepository);
            GetEmployeeByID(employeeRepository);


            var organizationRepository = new GenericRepository<Organization>();
            AddOrganizations(organizationRepository);

        }

        private static void GetEmployeeByID(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"2:{employee.Name}");
        }

        private static void AddEmployees(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { Name = "Julia" });
            employeeRepository.Add(new Employee { Name = "Anna" });
            employeeRepository.Add(new Employee { Name = "Thomas" });
            employeeRepository.Save();
        }

        private static void AddOrganizations(GenericRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "Pluralsight" });
            organizationRepository.Add(new Organization { Name = "Microsoft" });
            organizationRepository.Save();
        }
    }
}
