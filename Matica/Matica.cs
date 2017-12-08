using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matica
{
    class Matica
    {
        public int[,] matica = new int[2, 3];
        public int this[int x, int y]
        {
            get
            {
                return matica[x, y];
            }
            set
            {
                matica[x, y] = value;
            }
        }

        public Matica()
        {

            Random r = new Random();
            VytvorMaticu(r);
        }

        private void VytvorMaticu(Random r)
        {
            for (int i = 0; i < matica.GetLength(0); i++)
            {
                for (int j = 0; j < matica.GetLength(1); j++)
                {
                    matica[i, j] = r.Next(1, 11);
                }             
            }
        }

        public static Matica operator +(Matica M1, Matica M2)
        {
            Matica M3 = new Matica();
            for (int i = 0; i < M1.matica.GetLength(0); i++)
            {
                for (int j = 0; j < M1.matica.GetLength(1); j++)
                {
                    M3.matica[i, j] = M1.matica[i, j] + M2.matica[i, j];
                }

            }
            return M3;
        }

        public static Matica operator -(Matica M1, Matica M2)
        {
            Matica M3 = new Matica();
            for (int i = 0; i < M1.matica.GetLength(0); i++)
            {
                for (int j = 0; j < M1.matica.GetLength(1); j++)
                {
                    M3.matica[i, j] = M1.matica[i, j] - M2.matica[i, j];
                }

            }
            return M3;
        }

        public static Matica operator *(Matica M1, Matica M2)
        {
            Matica M3 = new Matica();
            for (int i = 0; i < M1.matica.GetLength(0); i++)
            {
                for (int j = 0; j < M1.matica.GetLength(1); j++)
                {
                    M3.matica[i, j] = M1.matica[i, j] * M2.matica[i, j];
                }

            }

            return M3;
        }
    }

}

