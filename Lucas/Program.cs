using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(args[0]);

            Console.WriteLine(Lucas(n));
        }

        /// <summary>
        /// Displays the Lucas sequence until index n
        /// </summary>
        /// <param name="n"> Limit index </param>
        /// <returns> Returns the number on n index </returns>
        private static int Lucas(int n)
        {
            if (n == 0)
                return 2;
            else if (n == 1)
                return 1;
            else
                return (Lucas(n - 2) + Lucas(n - 1));
        }
    }
}
