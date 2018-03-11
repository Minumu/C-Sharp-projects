using System;

namespace sorting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] sortArray= new int[11] { -35, 45, 3, 7, 4, 5, -1, 0, 20, 15, 8 };
            int swap = 0;
            int i = 0;
            int maxPos = 0;
            int maxVal = 0;
            while (i < sortArray.Length)
            {
                int j = i;
                maxVal = sortArray[i];
                maxPos = i;
                while (j < sortArray.Length)
                {
                    if (maxVal < sortArray[j])
                    {
                        maxPos = j;
                        maxVal = sortArray[j];
                    }
                    j++;
                }
                Console.Write($"{maxPos} ");
                swap = sortArray[i];
                sortArray[i] = sortArray[maxPos];
                sortArray[maxPos] = swap;
                i++;
            }
            Console.Write("\n");
            for (i = 0; i < sortArray.Length; i++)
                Console.Write($"{sortArray[i]} ");
        }
    }
}
