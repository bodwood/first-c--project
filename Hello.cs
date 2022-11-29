using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Enter a number to double: ");
    int userNum = Convert.ToInt32(Console.ReadLine());
    int doubledNum = userNum * 2;
    Console.WriteLine(doubledNum);
  }
}