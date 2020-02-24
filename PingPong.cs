using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter a number");
    string number = Console.ReadLine();
    int convertedNumber = int.Parse(number);
    List<string> numberList = new List<string> {};
    for (int i = 1; i <= convertedNumber; i++)
    {
      if (i % 15 == 0)
      {
        numberList.Add("ping-pong");
      }
      else if (i % 5 == 0)
      {
        numberList.Add("pong");
      }
      else if (i % 3 == 0)
      {
        numberList.Add("ping");
      }
      else
      {
        string index = i.ToString(); 
        numberList.Add(index);
      }
      Console.WriteLine(numberList[i-1]);
    }
  }
}