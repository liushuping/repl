using System;

namespace Repl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                Evaluate(input);
            }
        }

        public static void Evaluate(string input)
        {
            Console.WriteLine(input); // echo
        }
    }
}
