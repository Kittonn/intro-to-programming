using System;

class Program {
  public static void Main (string[] args) {
    int n;
      Console.Write("Enter the number of letters : ");
      n = Convert.ToInt32(Console.ReadLine());
      
      char[] letters = new char[n];
      for (int i = 0; i < n; i++)
      {
        Console.Write("letter - {0} : ",i+1);
        letters[i] = Convert.ToChar(Console.ReadLine());
      }
      Console.Write("Reverse order : ");
      for (int i = n - 1; i >= 0; i--)
      {
        Console.Write(letters[i] + " ");
      }
  }
}