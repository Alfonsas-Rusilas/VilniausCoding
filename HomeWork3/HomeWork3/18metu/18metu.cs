using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._18metu
{
    class _18metu
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite metus: ");
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >=18)
            {
                Console.WriteLine("Jūs turite bent 18 metų");
            }
            else
            {
                Console.WriteLine("Jūs per jaunas");
            }

            if (amzius % 2 ==0)
            {
                Console.WriteLine("Jūsų metų skaičius lyginis");
            }
            else
            {
                Console.WriteLine("Jūsų metų skaičius nelyginis");
            }

        }
    }
}
