using System;
using static System.Console;

namespace casting
{
  class Program
  {
    static void Main(string[] args)
    {
      // 
      double a1 = 9.8;
      int b1 = (int)a1;
      int b2 = Convert.ToInt32(a1);
      Write(b1 + "\t");
      Write(b2);
      WriteLine();

      double[] doubles = new[]
       { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
      foreach (double n in doubles)
      {
        WriteLine($"ToInt({n}) is {Convert.ToInt32(n)}");
      }
      foreach (double n in doubles)
      {
        WriteLine(format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}", arg0: n, arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
      }

      int number = 12;
      WriteLine(number.ToString());
      bool boolean = true;
      WriteLine(boolean.ToString());
      DateTime now = DateTime.Now;
      WriteLine(now.ToString());
      object me = new object();
      WriteLine(me.ToString());

      byte[] binaryObject = new byte[128];
      (new Random()).NextBytes(binaryObject);
      WriteLine("Binary Object as bytes:");
      for (int index = 0; index < binaryObject.Length; index++)
      {
        Write($"{binaryObject[index]:X} ");
      }
      WriteLine();
      string encoded = Convert.ToBase64String(binaryObject);
      WriteLine($"Binary Object as Base64: {encoded}");

      int age = int.Parse("27");
      DateTime birthday = DateTime.Parse("4 July 1980");
      WriteLine($"I was born {age} years ago.");
      WriteLine($"My birthday is {birthday}.");
      WriteLine($"My birthday is {birthday:D}");

      Write("How many eggs are there? ");
      int count;
      string input = Console.ReadLine();
      if (int.TryParse(input, out count))
      {
        WriteLine($"There are {count} eggs.");
      }
      else
      {
        WriteLine("I could not parse the input.");
      }

      WriteLine("Before parsing");
      Write("What is your age? ");
      string input1 = Console.ReadLine();
      try
      {
        int age1 = int.Parse(input1);
        WriteLine($"You are {age1} years old.");
      }
      catch (FormatException)
      {
        WriteLine("The age you entered is not a valid number format.");
      }
      catch (Exception ex)
      {
        WriteLine($"{ex.GetType()} says {ex.Message}");
      }
      WriteLine("After parsing");
    }
  }
}
