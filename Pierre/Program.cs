using System;
using Pierre.Models;

class Program
{
    static void Main()
    {
        bool runProgram = true;

        while (runProgram)
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("*~*~PIERRE'S BAKERY*~*~");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome! We hope you're hungry.");
            Console.WriteLine("Check out our prices below: ");
            Console.WriteLine("Pastry = $2 (Buy 3, get 4th free!)");
            Console.WriteLine("Bread = $5 (Buy 2, get 3rd free!)");
            Console.WriteLine("How many pastries would you like?");
            string pastryRequest = Console.ReadLine();
            Pastry newPastries = new Pastry(int.Parse(pastryRequest));
            Console.WriteLine(newPastries.NumberPastries + "? Sounds good.");
            Console.WriteLine("How many loaves of bread would you like?");
            string breadRequest = Console.ReadLine();
            Bread newBread = new Bread(int.Parse(breadRequest));
            Console.WriteLine(newBread.NumberBread + "? Sounds good.");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("*~*~PIERRE'S BAKERY*~*~");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine(
                "Your price for "
                    + newBread.NumberBread
                    + " loaves(or un loaf) of bread is $"
                    + newBread.GetPriceBread()
                    + " and the price for "
                    + newPastries.NumberPastries
                    + " pastries will be $"
                    + newPastries.GetPricePastry()
                    + ", so your grand total today is $"
                    + (newBread.GetPriceBread() + newPastries.GetPricePastry())
                    + "!"
            );
            Console.WriteLine("Thanks for shopping at Pierre's!");
            Console.WriteLine("Enter 'bakery' to shop again, or we will see you later!");
            string runItBack = Console.ReadLine();
            if (runItBack != "bakery")
            {
                runProgram = false;
            }
        }
    }
}
