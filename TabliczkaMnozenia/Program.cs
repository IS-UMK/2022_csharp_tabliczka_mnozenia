using System;

namespace TabliczkaMnozenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("    | ");
            for (int j = 1; j < n + 1; j++)
            {
                Console.Write(" {0,3} ", j);
            }
            Console.WriteLine();

            Console.Write("------");
            for (int j = 1; j < n + 1; j++)
            {
                Console.Write("-----");
            }
            Console.WriteLine();

            for (int i = 1; i < n + 1 ; i++)
            {
                Console.Write("{0,3} | ", i);
                for (int j = 1; j < n + 1; j++)
                {
                    Console.Write(" {0,3} ", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
