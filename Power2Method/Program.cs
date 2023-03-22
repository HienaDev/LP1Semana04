using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// Displays the power of 2 until 5, 7 and 10.
        /// </summary>
        /// <param name="args"> Arguments received from the terminal </param>
        static void Main(string[] args)
        {
            PowerOf2Until5();

            PowerOf2UntilN(7);
            PowerOf2UntilN(10);

            PowerOf2UntilN(7, 10);
        }

        /// <summary>
        /// Displays all powers of 2 until 5.
        /// </summary>
        private static void PowerOf2Until5()
        {
            PowerOf2UntilN(5);
        }

        /// <summary>
        /// Displays all powers of 2 until n.
        /// </summary>
        /// <param name="n"> Interger to limit the power of 2</param>
        private static void PowerOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i <<= 1)
            {
                Console.WriteLine(i);
            }
        }

        private static void PowerOf2UntilN(int n1, int n2)
        {
            for (int i = 1 << n1 ; i <= (1 << n2); i <<= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
