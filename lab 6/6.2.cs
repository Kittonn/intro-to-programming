using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.Write("Choose, 1: C to F or 2: F to C conversion : ");
      int choice = Convert.ToInt32(Console.ReadLine());
      if (choice == 1)      {
        Console.Write("Enter  Celsius : ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine("Fahrenheit is " + fahrenheit);
      }
      else if (choice == 2)
      {
        Console.Write("Enter  Fahrenheit : ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = FahrenheitToCelsius(fahrenheit);
        Console.WriteLine("Celsius is " + celsius);
      }
    }

    
    static double CelsiusToFahrenheit(int temp)
    {
      return (temp * 9 / 5) + 32;
    }
    
    static double FahrenheitToCelsius(int temp)
    {
      return (temp - 32) * 5 / 9;
    }

  }
}