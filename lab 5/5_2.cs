using System;


class Program
{
  static void Main(string[] args)
  {
    Console.Write("please enter the initial value :");
    int nums = Convert.ToInt32(Console.ReadLine());
    int sum = nums;
    while (sum <= 500)
    {
      Console.Write("Please enter the value you want to add to {0} :",sum);
      nums = Convert.ToInt32(Console.ReadLine());
      sum += nums;
    }
    Console.WriteLine("Thank you very much the final value is " + sum);
  }
}
