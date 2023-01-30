namespace FibonacciRecursion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, how many numbers of the fibonacci sequence would you like to receive?");
            var howMany = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you'd like to receive " + howMany + " back.");
            int[] arr = FibonaciCalculations(howMany);

            Console.WriteLine(string.Join(",", arr));
        }

        static int[] FibonaciCalculations(int howMany)
        {
            int[] fibonacci = new int[howMany];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < howMany; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }
    }
}
