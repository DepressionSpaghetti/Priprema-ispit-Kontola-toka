using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_kt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite neki string");
            string s = Console.ReadLine();
            if (s.Length < 5)
                Console.WriteLine(s);
            else
            {
                string sB = s.Substring(2, s.Length - 4);
                Console.WriteLine(sB);
            }

            Console.ReadKey();
        }
    }
}
