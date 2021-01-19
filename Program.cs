using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine("Addition: 10 + 3");
            Console.WriteLine(a + b);

            Console.WriteLine("-----------------\n");

            Console.WriteLine("Division: 10 / 3");
            Console.WriteLine((float)a / (float)b);

            Console.WriteLine("-----------------\n");

            a = 1;
            b = 2;
            var c = 3;

            Console.WriteLine("Order of operations: 1 + 2 * 3");
            Console.WriteLine(a + b * c);

            Console.WriteLine("-----------------\n");

            Console.WriteLine("Order of operations: (1 + 2) * 3");
            Console.WriteLine((a + b) * c);

            Console.WriteLine("-----------------\n");

            Console.WriteLine("Is 1 greater than 2: 1 > 2");
            Console.WriteLine(a > b);

            Console.WriteLine("-----------------\n");

            Console.WriteLine("Is 1 less than 2: 1 < 2");
            Console.WriteLine(a < b);

            Console.WriteLine("-----------------\n");

            Console.WriteLine("Is 1 equal to 2: 1 == 2");
            Console.WriteLine(a == b);

            Console.WriteLine("-----------------\n");


        }
    }
}
