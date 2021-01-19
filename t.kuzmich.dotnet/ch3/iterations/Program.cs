using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace iterations
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 0;
      while (x < 10)
      {
        Write(x + "\t");
        x++;
      }
      System.Console.WriteLine();

      string password = string.Empty;
      do
      {
        Write("Enter your password: ");
        password = ReadLine();
      }
      while (password != "0000");
      WriteLine("Correct!");

      for (int y = 1; y <= 10; y++)
      {
        Write(y + "\t");
      }
      System.Console.WriteLine();

      string[] names = { "Adam", "Barry", "Charlie" };
      foreach (string name in names)
      {
        WriteLine($"{name} has {name.Length} characters.");
      }
      System.Console.WriteLine();

      IEnumerator e = names.GetEnumerator();
      while (e.MoveNext())
      {
        string name = (string)e.Current; // Current is read-only!
        WriteLine($"{name} has {name.Length} characters.");
      }
    }
  }
}
