using System;

namespace Argumentos
{
    /// <summary>
    /// This program prints what the user writes in the console
    /// </summary>
    class Program
    {
        /// <summary>
        /// The program starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
