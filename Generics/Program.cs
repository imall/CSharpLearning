namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var stack = new SimpleStack<int>(10);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int sum = 0;


            while (stack.Count > 0)
            {

                var item = stack.Pop();
                Console.WriteLine(item);
                sum += item;
            }

            Console.WriteLine(sum);

        }
    }


    /// <summary>
    /// 綁定型別的堆疊
    /// </summary>
    public class SimpleStack
    {
        private readonly object[] _items;
        private int _currentIndex = -1;
        public SimpleStack() => _items = new object[10];
        public int Count => _currentIndex + 1;
        public void Push(object item) => _items[++_currentIndex] = item;
        public object Pop() => _items[_currentIndex--];

    }


    /// <summary>
    /// 泛型堆疊
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="capacity"></param>
    public class SimpleStack<T>(int capacity)
    {
        private readonly T[] _items = new T[capacity];
        private int _currentIndex = 0;

        public int Count => _currentIndex + 1;
        public void Push(T item) => _items[_currentIndex++] = item;
        public T Pop() => _items[_currentIndex--];
    }
}
