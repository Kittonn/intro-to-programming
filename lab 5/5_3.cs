using System;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the number of rows : ");
      int rows = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the character to : ");
      char character = Convert.ToChar(Console.ReadLine());
      for (int i = 1; i <= rows; i++)
      {
        for (int j = 1; j <= i; j++)
        {
          Console.Write(character);
        }
        Console.WriteLine();
      }
    }
  }
}