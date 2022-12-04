class Program
{
  static void Main(string[] args)
  {
    int sum = 0;
    int n;
    while (true)
    {
      Console.Write("Enter a two-digit number: ");
      n = Convert.ToInt32(Console.ReadLine());
      if(n >= 10 && n <= 99) {
        sum += n;
      } else if (n == 100) {
        break;
      } else if (!(n >= 10 && n <= 99)) {
        Console.WriteLine("Please enter only two-digit numbers.");
      }
    }
    Console.WriteLine("Total sum of two-digit numbers is " + sum);
  }
}