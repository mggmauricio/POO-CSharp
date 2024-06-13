using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 1.289868F;
            double y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            int a = 1;
            uint b = (uint)a; //casting
            Console.WriteLine(a);
    }
}
}