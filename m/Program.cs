using System;

namespace m
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)     //公鸡最多只能有19只
            {
                for (int j = 0; j < 33; j++)  //母鸡最多有32只
                {
                    if ((100 - i - j) % 3 == 0 && i * 5 + j * 3 + (100 - i - j) / 3 == 100)  //满足花百钱，鸡百只输出
                    {
                        Console.WriteLine("公鸡有{0},母鸡有{1},小鸡有{2}", i, j, 100 - i - j);
                    }
                }
            }

            Console.Read();
        }
    }
}    

