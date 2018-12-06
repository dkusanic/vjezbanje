using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int M = 0;
            int Z = 0;
            Console.WriteLine("Unesi broj N:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj M:");
            M = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("crno");
            }
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine("bijelo");
            }
            Console.ReadLine();
        }
    }
}
