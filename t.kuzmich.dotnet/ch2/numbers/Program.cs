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

            dynamic a = "123";
            System.Console.WriteLine(a);
            a = 12;
            Console.WriteLine(a);
        }
    }
}
