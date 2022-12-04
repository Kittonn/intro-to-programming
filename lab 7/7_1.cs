using System;


class Program
{
  static void Main(string[] args)
  {
    int[] numbers = new int[10];
    int sum = 0;
    int Max_score = 0;
    for (int i = 0; i < 10; i++)
    {
      numbers[i] = Convert.ToInt32(Console.ReadLine());
      sum += numbers[i];
      if (numbers[i] > Max_score)
      {
        Max_score = numbers[i];
      }
    }
    
    float average = (float)sum / 10;
    Console.WriteLine("Average score: " + average);
    Console.WriteLine("The highest score is: " + Max_score);
  }
}
