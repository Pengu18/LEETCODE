using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      //This dosent work because you cant read a double as a int cant jut randomly convert something to another thing like its magic
      
      //####int favNumber = Conole.ReadLine();

      //This also dosnt work because it is not possible to explicitly convert a string into an int (or vice versa) in C#
      
      //#### int favNumber = (int)Console.ReadLine();

      //This is the *****working***** method here uses a builtin C# method to convert the double into a int so we can properly use it for what ever it is required for
      int faveNumber = Convert.ToInt32(Console.ReadLine());

      Console.Write(faveNumber);
    }
  }
}
