namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<int>(10);

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
}
