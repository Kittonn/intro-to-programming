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
      Console.Write("The order are : ");

      for (int i = 0; i < 5; i++)
      {
        int min = numbers[i];
        int minIndex = i;
        for (int j = i; j < 5; j++)
        {
          if (min > numbers[j])
          {
            min = numbers[j];
            minIndex = j;
          }
        }
        int temp = numbers[i];
        numbers[i] = min;
        numbers[minIndex] = temp;
        Console.Write("{0} ",numbers[i]);
      }
    }
  }
}