namespace FibonacciRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, how many numbers of the fibonacci sequence would you like to receive?");
            var howMany = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you'd like to receive " + howMany + " back.");
        }

        static int FibonaciCalculations(int howMany)
        {
            int count = 0;
            while (count < howMany)
            {
                //declaration
                int i = 0;
                int j = i - 1;
                int[] fibonacci = new int[i];


                int next = fibonacci[i] + fibonacci[j];
                FibonaciCalculations(i);
            }

            return howMany;
        }
    }
}