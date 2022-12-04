using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("please enter the radius :");
      int radius = Convert.ToInt32(Console.ReadLine());
      double area = SphereArea(radius);
      double circumference = SphereCircumference(radius);

      Console.WriteLine("The area of the sphere is " + area);
      Console.WriteLine("The circumference of the sphere is " + circumference);
    }


    static double SphereArea(int radius)
    {
      return 4 * Math.PI * Math.Pow(radius, 2);
    }
  
    static double SphereCircumference(int radius)
    {
      return 2 * Math.PI * radius;
    } 

  }
}