using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T> where T : EntityBase
    {


        private readonly List<T> _employees = [];

        public T GetById(int id)
        {
            return _employees.Single(x => x.Id == id);
        }

        public void Add(T employee)
        {
            //employee.Id = _employees.Count + 1;
            employee.Id = _employees.Count != 0 ? _employees.Max(x => x.Id) + 1 : 1;
            _employees.Add(employee);
        }

        public void Save()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine(employee);
            }
        }
    }


}
