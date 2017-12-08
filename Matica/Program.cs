using System;

namespace Matica
{
    class Program
    {
        static void Main(string[] args)
        {

            Matica M1 = new Matica();

            for (int i = 0; i < M1.matica.GetLength(0); i++)
            {
                for (int j = 0; j < M1.matica.GetLength(1); j++)
                {
                    Console.WriteLine(M1.matica[i, j]);
                }
            }
            
            Console.WriteLine("---------------");

            Matica M2 = new Matica();

            for (int i = 0; i < M2.matica.GetLength(0); i++)
            {
                for (int j = 0; j < M2.matica.GetLength(1); j++)
                {
                    Console.WriteLine(M2.matica[i, j]);
                }
            }

            Console.WriteLine("--------plus-------");

            Matica M3 = M1 + M2;

            for (int i = 0; i < M3.matica.GetLength(0); i++)
            {
                for (int j = 0; j < M3.matica.GetLength(1); j++)
                {
                    Console.WriteLine(M3.matica[i, j]);
                }
            }

            Console.WriteLine("--------minus-------");

            Matica M4 = M1 - M2;

            for (int i = 0; i < M4.matica.GetLength(0); i++)
            {
                for (int j = 0; j < M4.matica.GetLength(1); j++)
                {
                    Console.WriteLine(M4.matica[i, j]);
                }
            }

            Console.WriteLine("-------nasobenie--------");

            Matica M5 = M1 * M2;

            for (int i = 0; i < M5.matica.GetLength(0); i++)
            {
                for (int j = 0; j < M5.matica.GetLength(1); j++)
                {
                    Console.WriteLine(M5.matica[i, j]);
                }
            }

            Console.WriteLine("---------------");

            Matica M6 = new Matica();
            int[,] maticaIdentity = M6.MaticaIdentity(3);

            for (int i = 0; i < maticaIdentity.GetLength(0); i++)
            {
                for (int j = 0; j < maticaIdentity.GetLength(1); j++)
                {
                    Console.WriteLine(maticaIdentity[i, j]);
                }
            }


            Console.ReadKey();
        }
    }
}
