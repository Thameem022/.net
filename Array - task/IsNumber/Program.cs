using System;

namespace ToCheckIfTextIsNumber
{
    class IsNumber
    {
        static void Main()
        {
            string? a;
            a = Console.ReadLine();
            var isNumeric = int.TryParse(a, out _);
            if (isNumeric)
                Console.WriteLine("{0} is a number.", a);
            else
                Console.WriteLine("{0} is not a number.", a);
        }
    }
}