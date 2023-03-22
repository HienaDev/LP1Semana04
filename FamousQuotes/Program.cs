using System;

namespace FamousQuotes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("You talking to me?");
            MyPrecious();
            Console.WriteLine("Dodge this");
            Hasta();
        }

        /// <summary>
        /// Prints "Hasta la vista, baby."
        /// </summary>
        private static void Hasta()
        {
            TheMoney();
            Console.WriteLine("Hasta la vista, baby.");
            MyPrecious();
        }

        /// <summary>
        /// Prints "Show me the money!"
        /// </summary>
        private static void TheMoney()
        {
            Console.WriteLine("Show me the money!");
        }

        /// <summary>
        /// Prints "My precious."
        /// </summary>
        private static void MyPrecious()
        {
            TheMoney();
            Console.WriteLine("My precious.");
        }
    }
}
