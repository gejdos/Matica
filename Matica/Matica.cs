using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matica
{
    class Matica
    {

        public static int[,] VytvorMaticu(int rozmer1, int rozmer2)
        {
            int[,] matica = new int[rozmer1, rozmer2];
            Random r = new Random();

            for (int i = 0; i < matica.GetLength(0); i++)
            {
                for (int j = 0; j < matica.GetLength(1); j++)
                {
                    matica[i, j] = r.Next(21);
                }             
            }

            for (int i = 0; i < matica.GetLength(0); i++)
            {
                for (int j = 0; j < matica.GetLength(1); j++)
                {
                    Console.WriteLine(matica[i, j]);
                }
            }

            return matica;
        }

        public static void Spocitaj(int[,] M1, int[,] M2)
        {
            int[,] novaMatica = new int[M1.GetLength(0), M1.GetLength(1)];

            for (int i = 0; i < M1.GetLength(0); i++)
            {
                for (int j = 0; j < M1.GetLength(1); j++)
                {
                    novaMatica[i, j] = M1[i, j] + M2[i, j];
                }
            }

            

        }
    }
}
