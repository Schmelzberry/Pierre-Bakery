using System;
using Pierre.Models;

class Program
  {
  static void Main()
    {
    Console.WriteLine("How many pastries would you like?");
    string pastryRequest = Console.ReadLine();
    Pastry newPastries = new Pastry(int.Parse(pastryRequest));
    Console.WriteLine(newPastries);
    }

  }
