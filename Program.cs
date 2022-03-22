using System;

namespace findMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            int b = int.Parse(Console.ReadLine());
            //1st 

            /*int max = a;
            if (b > a)
                max = b;
            */

            //2nd

            /* int max;
             if (a > b)
                 max = a;
             else
                 max = b;
             */

            //3-е решение
            int max = a > b ? a : b; //тернарная операция

            Console.WriteLine($"Maximum is: {max}");
        }
    }
}
