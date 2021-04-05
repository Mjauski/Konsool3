
using System;

namespace RefVsOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 2;

            Method1(out first, out second); // 2 1
            Method2(first, ref second); // 
            Method3(ref first, second); // Ref ja out lisaga muutuja v‰‰rtust saab muuta, ilma nendeta mitte

            Console.WriteLine($"first: {first}, second: {second}");
            Console.ReadLine();

        }

        static void Method1(out int a, out int b) // Vahetab ‰ra muutujate v‰‰rtused
        {
            a = 2;
            b = 1;
        }

        static void Method2(int a, ref int b) // Annab b-le v‰‰rtuse 10 (5*2), a j‰‰b samaks
        {
            a *= 5;
            b *= a;
        }

        static void Method3(ref int a, int b) // Annab a-le v‰‰rtuse 10 (5*2), b j‰‰b samaks, ehk siis 10 eelmisest meetodist
        {
            a *= 5;
            b *= b;
        }
    }
}