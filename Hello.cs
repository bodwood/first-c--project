using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Enter a number to double: ");
    string userNum = Console.ReadLine();
    int doubledNum = int.Parse(userNum) * 2; //int.Parse converts string to int
    string userMessage = userNum + " doubled is " + doubledNum.ToString();
    Console.WriteLine(userMessage);
  }
}