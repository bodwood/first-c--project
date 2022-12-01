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
    if (int.Parse(userAge) >= 18)
    {
      Console.WriteLine("Welcome in! Here is your ticket!");
    }
    else
    {
      Console.WriteLine("You must be at least 18 years old to watch a rated R movie.");
    }
    Console.WriteLine();

    //Branching with booleans
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();
    if (userName.StartsWith("B"))
    {          // StartsWith is a built in C# method to check if the user input starts with a certain character
      Console.WriteLine("Your name starts with a B!");
    }
    else
    {
      Console.WriteLine("Your name does NOT start with a B.");
    }

    Console.WriteLine();

    Console.WriteLine("In what season are you booking a stay?");
    string season = Console.ReadLine();

    Console.WriteLine("On the weekend or a weeknight?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";      //bool summer is true if season equals "summer"
    bool weekend = dayOfWeek == "weekend"; //bool weekend is true is dayOfWeek equals "weekend"

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is going to be expensive due to peak travel season and a weekend");
    }
    else if (!(summer || weekend))
    {
      Console.WriteLine("Your stay is the cheapest it could be!");
    }
    else
    {
      Console.WriteLine("Your stay is in summer or during a weekend, so this will get pricy!");
    }

    Console.WriteLine();

    int[] numbersDoubled = {1, 2, 3, 4};
    foreach(int i in numbersDoubled){
      Console.WriteLine(i*2);
    }
  }
}