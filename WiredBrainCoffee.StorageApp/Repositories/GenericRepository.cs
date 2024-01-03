namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _employees = [];

        public void Add(T employee)
        {
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
