using System;
using static System.Console;

namespace operands
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int incrementedByOne = x++;
      int incrementedByOneAgain = ++x;
      Type theTypeOfAnInteger = typeof(int);
      int howManyBytesInAnInteger = sizeof(int);
      Write($"{x} {incrementedByOne} {incrementedByOneAgain} {theTypeOfAnInteger} {howManyBytesInAnInteger} \n");

      int a = 3, b = a++, c = ++b;
      Write($"a is {a}, b is {b}, c is {c} \n\n");

      int e = 11;
      int h = 3;
      double g = 11.0;
      WriteLine($"e is {e}, g is {g:N1}, f is {h}");
      WriteLine($"e + f = {e + h}");
      WriteLine($"e - f = {e - h}");
      WriteLine($"e * f = {e * h}");
      WriteLine($"e / f = {e / h}");
      WriteLine($"g / f = {g / h}");
      WriteLine($"e % f = {e % h}");
      WriteLine();

      bool t = true;
      bool f = false;
      WriteLine(t & t);
      WriteLine(t & f);
      WriteLine(f & f);
      WriteLine();
      WriteLine(t | t);
      WriteLine(t | f);
      WriteLine(f | f);
      WriteLine();
      WriteLine(t ^ t);
      WriteLine(t ^ f);
      WriteLine(f ^ f);
      WriteLine();

      int k = 12;
      WriteLine(k >> 1);
      WriteLine(k >> 2);
      WriteLine(k >> 3);
      WriteLine();

      int age = 47;
      string firstDigit = age.ToString()[0].ToString();
      WriteLine(firstDigit);
    }
  }
}
