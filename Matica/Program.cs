using System;

namespace Matica
{
    class Program
    {
        static void Main(string[] args)
        {

            Matica M1 = new Matica();

            for (int i = 0; i < M1.NovaMatica().GetLength(0); i++)
            {
                for (int j = 0; j < M1.NovaMatica().GetLength(1); j++)
                {
                    Console.WriteLine(M1.NovaMatica()[i, j]);
                }
            }

            Console.WriteLine("---------------");

            Matica M2 = new Matica();

            for (int i = 0; i < M2.NovaMatica().GetLength(0); i++)
            {
                for (int j = 0; j < M2.NovaMatica().GetLength(1); j++)
                {
                    Console.WriteLine(M2.NovaMatica()[i, j]);
                }
            }

            Console.WriteLine("--------plus-------");

            Matica M3 = M1 + M2;

            for (int i = 0; i < M3.NovaMatica().GetLength(0); i++)
            {
                for (int j = 0; j < M3.NovaMatica().GetLength(1); j++)
                {
                    Console.WriteLine(M3.NovaMatica()[i, j]);
                }
            }

            Console.WriteLine("--------minus-------");

            Matica M4 = M1 - M2;

            for (int i = 0; i < M4.NovaMatica().GetLength(0); i++)
            {
                for (int j = 0; j < M4.NovaMatica().GetLength(1); j++)
                {
                    Console.WriteLine(M4.NovaMatica()[i, j]);
                }
            }

            Console.WriteLine("-------nasobenie--------");

            Matica M5 = M1 * M2;

            for (int i = 0; i < M5.NovaMatica().GetLength(0); i++)
            {
                for (int j = 0; j < M5.NovaMatica().GetLength(1); j++)
                {
                    Console.WriteLine(M5.NovaMatica()[i, j]);
                }
            }

            Console.WriteLine("---------------");

            Matica M6 = new Matica();

            for (int i = 0; i < M6.MaticaIdentity().GetLength(0); i++)
            {
                for (int j = 0; j < M6.NovaMatica().GetLength(1); j++)
                {
                    Console.WriteLine(M6.MaticaIdentity()[i, j]);
                }
            }


            Console.ReadKey();
        }
    }
}
