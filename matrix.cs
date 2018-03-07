using System;

namespace arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2] {{2,1},{2,3}};
            int[,] matrix2 = new int[2, 2] {{1,3},{2,1}};
            int[,] matrixMult = new int[2, 2] {{0,0},{0,0}};

            for (int i = 0; i < 2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                        matrixMult[i,j] += matrix1[i,k] * matrix2[k,j];
                    Console.Write(matrixMult[i, j] + "|");
                }
                Console.WriteLine();
            }

        }
    }
}
