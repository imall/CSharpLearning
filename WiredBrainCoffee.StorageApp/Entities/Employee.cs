namespace WiredBrainCoffee.StorageApp.Entities
{


    public class Employee : EntityBase
    {

        public string? Name { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}";
        }
    }
}
