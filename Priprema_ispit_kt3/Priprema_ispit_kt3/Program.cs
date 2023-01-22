using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_kt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite neki broj:");
            int br = Convert.ToInt32(Console.ReadLine());
            if (br % 4 == 0 && br % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
            else if (br % 4 == 0)
                Console.WriteLine("Broj je djeljiv sa 4");
            else if (br % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 6");
            else
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6");

            Console.ReadKey();
        }
    }
}
