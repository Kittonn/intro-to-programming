using System;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Write("Choose, 1: C to F or 2: F to C conversion : ");
      int choice = Convert.ToInt32(Console.ReadLine());
      if (choice == 1)      {
        Console.Write("Enter Celsius : ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine("Fahrenheit is " + fahrenheit.ToString("F1"));
      }
      else if (choice == 2)
      {
        Console.Write("Enter Fahrenheit : ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = FahrenheitToCelsius(fahrenheit);
        Console.WriteLine("Celsius is " + celsius.ToString("F1"));
      }
    }


    static double CelsiusToFahrenheit(double temp)
    {
      return (temp * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double temp)
    {
      return (temp - 32) * 5 / 9;
    }
  }
}