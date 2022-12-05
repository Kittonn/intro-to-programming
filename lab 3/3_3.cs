using System;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      string id_1, id_2, id_3;
      double price_1, price_2, price_3;
      int quantity_1, quantity_2, quantity_3;
      Console.Write("Enter 1st Product ID : ");
      id_1 = Console.ReadLine();
      Console.Write("Enter 1st Product Price (THB) : ");
      price_1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter 1st Product Quantity : ");
      quantity_1 = Convert.ToInt32(Console.ReadLine());
      
      Console.Write("Enter 2nd Product ID : ");
      id_2 = Console.ReadLine();
      Console.Write("Enter 2nd Product Price (THB) : ");
      price_2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter 2nd Product Quantity : ");
      quantity_2 = Convert.ToInt32(Console.ReadLine());
      
      Console.Write("Enter 3rd Product ID : ");
      id_3 = Console.ReadLine();
      Console.Write("Enter 3rd Product Price (THB) : ");
      price_3 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter 3rd Product Quantity : ");
      quantity_3 = Convert.ToInt32(Console.ReadLine());

      double total_1 = price_1 * quantity_1;
      double total_2 = price_2 * quantity_2;
      double total_3 = price_3 * quantity_3;
      double total = total_1 + total_2 + total_3;
      Console.WriteLine("Total Price (THB) : " + total.ToString("F2"));
    }
  }
}
