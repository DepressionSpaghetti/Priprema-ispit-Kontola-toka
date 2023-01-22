using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_kt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a:");
            double bezPDV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite cijenu s PDV-om:");
            double sPDV = Convert.ToDouble(Console.ReadLine());
            if (sPDV < bezPDV)
                Console.WriteLine("Cijene nisu ispravno unešene");
            else
                Console.WriteLine("PDV iznosi {0} %",
                (sPDV - bezPDV) / bezPDV * 100);

            Console.ReadKey();
        }
    }
}
