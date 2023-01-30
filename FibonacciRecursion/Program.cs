using System.Diagnostics.Metrics;

namespace FibonacciRecursion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, how many numbers of the fibonacci sequence would you like to receive?");
            int howMany = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[howMany];
            Console.WriteLine("you'd like to receive " + howMany + " back.");
            FibonaciCalculations(arr, 0, howMany);

            Console.WriteLine(string.Join(",", arr));
        }

        static void FibonaciCalculations(int[] arr, int start, int end)
        {
            if (start == end)
            {
                return;
            }
            if (start == 0)
            {
                arr[start] = 1;
                FibonaciCalculations(arr, start + 1, end);
            }
            else if (start == 1)
            {
                arr[start] = 1;
                FibonaciCalculations(arr, start+1, end);
            } else
            {
                arr[start] = arr[start - 1] + arr[start - 2];
                FibonaciCalculations(arr, start + 1, end);
            }
        }
    }
}