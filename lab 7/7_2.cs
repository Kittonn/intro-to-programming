using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input the number of elements to be stored in the array : ");
      int n = Convert.ToInt32(Console.ReadLine());
      int[] numbers = new int[n];
      Console.WriteLine("Input 5 elements in the array : ");
      for (int i = 0; i < n; i++)
      {
        Console.Write("element - {0} : ", i);
        numbers[i] = Convert.ToInt32(Console.ReadLine());
      }
      
      int[] even = new int[n];
      int[] odd = new int[n];
      int even_count = 0;
      int odd_count = 0;
      
      for (int i = 0; i < n; i++)
      {
        if (numbers[i] % 2 == 0)
        {
          even[even_count] = numbers[i];
          even_count++;
        }
        else
        {
          odd[odd_count] = numbers[i];
          odd_count++;
        }
      }
      Console.WriteLine("The Even elements are : ");
      for (int i = 0; i < even_count; i++)
      {
        Console.Write(even[i]);
        Console.Write(" ");
      }
      console.WriteLine();
      Console.WriteLine("The odd elements are : ");
      for (int i = 0; i < odd_count; i++)
      {
        Console.Write(odd[i]);
        Console.Write(" ");
      }
    }
  }
}