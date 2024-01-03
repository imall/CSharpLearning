using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            employeeRepository.Add(new Employee { Id = 1, Name = "Julia" });
            employeeRepository.Add(new Employee { Id = 2, Name = "Anna" });
            employeeRepository.Add(new Employee { Id = 3, Name = "Thomas" });
            employeeRepository.Save();


            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization { Id = 1, Name = "Pluralsight" });
            organizationRepository.Add(new Organization { Id = 2, Name = "Microsoft" });
            organizationRepository.Save();

        }
    }
}
