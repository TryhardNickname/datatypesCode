using dtarr_dsarr;
using dtarr_dssll;
using dtstack_dsarr;
// using dtstack_dslink;
using dtqueue_dssll.cs;
using System;


namespace datatypes 
{
    class Program
    {
        static void Main(string[] args)
        {
            dtarr_dssll.Array<int> arr = new dtarr_dssll.Array<int>(new int[] { 2, 3, 5, 7 });
            Console.WriteLine($"arr.Length() = {arr.Length()}");
            Console.WriteLine($"arr = {arr}");

            dtarr_dssll.Array<string> a2 = new dtarr_dssll.Array<string>(new string[] { "ole", "dole", "doff" });
            Console.WriteLine($"{a2}");

            dtstack_dsarr.Stack<int> stack = new dtstack_dsarr.Stack<int>(10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * i);
                stack.Push(i * i);
            }
            Console.WriteLine($"{stack}");
            while (!stack.isEmpty())
            {
                Console.Write($"{stack.Pop()}, ");
            }
            Console.WriteLine();

            Queue<double> queue = new Queue<double>(10);
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(Math.Sqrt(i));
            }
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine($"{queue.Dequeue()}");
            }
        }
    }
}
