using System;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      double num1,num2;
      char oper;
      Console.Write("enter the first digit : "); 
      num1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("enter the second digit : ");
      num2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("enter the oprator here : ");
      oper = Convert.ToChar(Console.ReadLine());
      Console.WriteLine("char is " + oper);      
      
      if (oper == '+') {
        Console.WriteLine("answer is " + (num1 + num2).ToString("F2"));
      } else if (oper == '-') {
        Console.WriteLine("answer is " + (num1 - num2).ToString("F2"));
      } else if (oper == '*') {
        Console.WriteLine("answer is " + (num1 * num2).ToString("F2"));
      } else if (oper == '/') {
        Console.WriteLine("answer is " + (num1 / num2).ToString("F2"));
      } 
    }
  }
}
