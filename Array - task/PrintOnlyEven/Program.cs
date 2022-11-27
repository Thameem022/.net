using System;

namespace TaskOnArray
{
    class PrintEven
    {
        static void Main()
        {
            int[] n = new int[10];
            int i;
            // Array n takes value 100-109, to avoid manual input by user
            for (i = 0; i < 10; i++)
            {
                n[i] = i;
            }
            Console.WriteLine("Even numbers between 0-9:\n");
            for (i = 0; i < 10; i++)
            {
                if (i % 2 == 0 && i != 0)
                    Console.WriteLine("{0}", n[i]);
            }
        }
    }
}