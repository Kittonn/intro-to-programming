using System;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      double velocity, distance;
      int t;
      Console.Write("Please enter the initial velocity : ");
      velocity = Convert.ToDouble(Console.ReadLine());
      Console.Write("Please enter traveled time : ");
      t = Convert.ToInt32(Console.ReadLine());
      if (t > -1) {
        distance = (velocity * t) + (9.8 * 0.5 * t * t);
        Console.WriteLine("The distance traveled is " + distance .ToString("F2") + " m.");
      } else {
        Console.WriteLine("Please enter the correct time");
      }
    }
  }
}
