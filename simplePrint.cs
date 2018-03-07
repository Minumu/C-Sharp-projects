using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            for (int i = 0; i < 1000; i++)
            {
                num1 = i / 100;
                num2 = i / 10 % 10;
                num3 = i % 10;
                if (num1 + num2 + num3 == 15)
                    Console.WriteLine(i);
            }
        }
    }
}
