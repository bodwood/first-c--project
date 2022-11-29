using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Enter a number to double: ");
    string userNum = Console.ReadLine();
    int doubledNum = int.Parse(userNum) * 2;
    Console.WriteLine(doubledNum);
  }
}