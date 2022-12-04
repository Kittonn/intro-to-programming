using System;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      
      int[] numbers = new int[5];
      for (int i = 0; i < 5; i++)
      {
        Console.Write("input[{0}] : ",i);
        numbers[i] = Convert.ToInt32(Console.ReadLine());
      }
      Console.Write("The odd number are : ");
      for (int i = 0; i < 5; i++)
      {
        if (numbers[i] % 2 == 1)
        {
          Console.Write("{0} ", numbers[i]);
        }
      }
    }
  }
}
