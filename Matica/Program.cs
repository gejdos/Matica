using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matica1 = Matica.VytvorMaticu(4, 3);
            int[,] matica2 = Matica.VytvorMaticu(4, 3);
            Console.WriteLine(Matica.Spocitaj(matica1, matica2));

            Console.ReadKey();
        }
    }
}
