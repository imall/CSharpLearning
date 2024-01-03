namespace Generics
{
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
