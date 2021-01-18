#nullable enable

using System;

namespace nulling
{
  class Program
  {
    static void Main(string[] args)
    {
      int thisCannotBeNull = 4;
      // try
      // {
      //     thisCannotBeNull = null;
      // }
      // catch (Exception ex)
      // {
      //     System.Console.WriteLine(ex.Message);
      // }
      int? thisCouldBeNull = null;
      Console.WriteLine(thisCouldBeNull);
      Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
      thisCouldBeNull = 7;
      Console.WriteLine(thisCouldBeNull);
      Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

      var address = new Address();
      address.Building = null;
      address.Street = null;
      address.City = "London";
      address.Region = null;

      string authorName = null;
      // the following throws a NullReferenceException
      int x = authorName.Length;
      // instead of throwing an exception, null is assigned to y
      int? y = authorName?.Length;
    }
  }
  class Address
  {
    public string? Building;
    public string Street;
    public string City;
    public string Region;
  }
}
