using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            Console.WriteLine(decimalNotation);
            Console.WriteLine(binaryNotation);
            Console.WriteLine(hexadecimalNotation);

            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            decimal c = 0.1M;
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }

            dynamic aa = "123";
            System.Console.WriteLine(aa);
            aa = 12;
            Console.WriteLine(aa);

            bool happy = true;
            bool sad = false;

            string str = null;
            System.Console.WriteLine(str);
        }
    }
}
