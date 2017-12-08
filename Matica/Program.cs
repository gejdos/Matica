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

            Matica matica1 = new Matica();
            for (int i = 0; i < matica1.matica.GetLength(0); i++)
            {
                for (int j = 0; j < matica1.matica.GetLength(1); j++)
                {
                    Console.WriteLine(matica1.matica[i, j]);
                }
            }

            Console.WriteLine("---------------");

            Matica matica2 = new Matica();
            for (int i = 0; i < matica2.matica.GetLength(0); i++)
            {
                for (int j = 0; j < matica2.matica.GetLength(1); j++)
                {
                    Console.WriteLine(matica2.matica[i, j]);
                }
            }

            Console.WriteLine("--------plus-------");

            Matica matica3 = matica1 + matica2;

            for (int i = 0; i < matica3.matica.GetLength(0); i++)
            {
                for (int j = 0; j < matica3.matica.GetLength(1); j++)
                {
                    Console.WriteLine(matica3.matica[i, j]);
                }
            }

            Console.WriteLine("--------minus-------");

            Matica matica4 = matica1 - matica2;

            for (int i = 0; i < matica4.matica.GetLength(0); i++)
            {
                for (int j = 0; j < matica4.matica.GetLength(1); j++)
                {
                    Console.WriteLine(matica4.matica[i, j]);
                }
            }

            Console.WriteLine("-------nasobenie--------");

            Matica matica5 = matica1 * matica2;

            for (int i = 0; i < matica5.matica.GetLength(0); i++)
            {
                for (int j = 0; j < matica5.matica.GetLength(1); j++)
                {
                    Console.WriteLine(matica5.matica[i, j]);
                }
            }

            Console.WriteLine("---------------");


            Console.ReadKey();
        }
    }
}
