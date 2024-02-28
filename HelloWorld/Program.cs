using System;

namespace HelloWord
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var myInt = 55;
      var mySecondInt = 10;


      if (myInt < mySecondInt)
      {
        Console.WriteLine(true);
      }
      else
      {
        Console.WriteLine(false);
      }
    }
  }
}
