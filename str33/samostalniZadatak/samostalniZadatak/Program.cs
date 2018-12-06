using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samostalniZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 30;
            int rezultat = 0;
            for(int N=10;N<=M;N++)
            {
                rezultat += N;
            }
            Console.WriteLine("Zborj svih prirodnih brojeva od 10 do 30 je "+rezultat);
            Console.ReadLine();
        }
    }
}
