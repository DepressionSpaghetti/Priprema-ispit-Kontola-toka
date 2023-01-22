using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_kt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;
            for (int i = 0; i<3; i++)
            {
                switch(i)
                {
                    case(0):
                        Console.WriteLine("Upisite Varijablu x");
                        x = Convert.ToInt32(Console.ReadLine());
                        break;
                    case(1):
                        Console.WriteLine("Upisite varijablu y");
                        y = Convert.ToInt32(Console.ReadLine());
                        break;
                    case(2):
                        Console.WriteLine("Upisite varijablu z");
                        z = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            if ((x * x + y * y == z * z
                || x * x + z * z == y * y
                || y * y + z * z == x * x)
                && x > 0 && y > 0 && z > 0)
                Console.WriteLine("Trokut je pravokutan");
            else
                Console.WriteLine("Trokut nije pravokutan");

            Console.ReadKey();
        }
    }
}
