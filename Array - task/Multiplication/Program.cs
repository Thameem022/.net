using System;

namespace MultiplicationWithoutOperator
{
    public class Product
    {
        static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            int i;

            for(i=0; i<y;i++){
                result+=x;
            }

            Console.WriteLine("Product of {0} & {1}: {2} ",x,y,result);

        }
    }
}