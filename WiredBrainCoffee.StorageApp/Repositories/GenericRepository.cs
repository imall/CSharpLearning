namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T, TKey>
    {

        public TKey? Key { get; set; }

        protected readonly List<T> _employees = [];

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


    public class GenericEmployeeRepositoryWithRemove<T> : GenericRepository<T, string>
    {
        public void Remove(T employee)
        {
            _employees.Remove(employee);

        }
    }
}
