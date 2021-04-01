using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.MokinioPazymys
{
    class MokinioPazymys
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite pažymį: ");
            int paz = Convert.ToInt32(Console.ReadLine());

            if (paz>10 || paz <1)
            {
                Console.WriteLine("Klaida.");
            }
            else if (paz == 10)
            {
                Console.WriteLine("puiku");
            }
            else if (paz == 9 || paz ==8)
            {
                Console.WriteLine("labai gerai");
            }
            else if (paz == 7 || paz == 6)
            {
                Console.WriteLine("gerai");
            }
            else if (paz == 5)
            {
                Console.WriteLine("vidutiniškai");
            }
            else if (paz == 4)
            {
                Console.WriteLine("bent teigiamai");
            }
            else 
            {
                Console.WriteLine("Labai blogai");
            }
            Console.Write("Programos pabaiga.");
        }
    }
}
