using System;
using Pierre.Models;
class Program
 {
  static void Main()
    {
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("*~*~PIERRE'S BAKERY*~*~");
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Welcome! We hope you're hungry.");
    Console.WriteLine("How many pastries would you like?");
    string pastryRequest = Console.ReadLine();
    Pastry newPastries = new Pastry(int.Parse(pastryRequest));
   Console.WriteLine(newPastries.NumberPastries + "? Sounds good.");
   Console.WriteLine("How many loaves of bread would you like?");
   string breadRequest = Console.ReadLine();
   Bread newBread = new Bread(int.Parse(breadRequest));
   Console.WriteLine(newBread.NumberBread + "? Sounds good.");
    Console.WriteLine("Your final price for " + newPastries.NumberPastries + " pastries will be $" + newPastries.GetPricePastry() + "! Every 4th pastry is on us!");
   Console.ReadLine();

    }
 }
