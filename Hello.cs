using System;

class SeeSharp
{
  static void Main()
  {
    //Integers and Strings
    Console.WriteLine("Enter a number to double: ");
    string userNum = Console.ReadLine();
    int doubledNum = int.Parse(userNum) * 2; //int.Parse converts string to int
    string userMessage = userNum + " doubled is " + doubledNum.ToString();  //.ToString() converts integers to a string
    Console.WriteLine(userMessage);
    Console.WriteLine(" ");

    //Branching
    Console.WriteLine("Enter your age: ");
    string userAge = Console.ReadLine();
    if(int.Parse(userAge) >= 18){
      Console.WriteLine("Welcome in! Here is your ticket!");
    } else {
      Console.WriteLine("You must be at least 18 years old to watch a rated R movie.");
    }
  }
}