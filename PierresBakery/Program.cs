using PierresBakery.Models;
using System;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine();
      Console.WriteLine("Today's Menu:");
      Console.WriteLine(" - Bread : $3");
      Console.WriteLine(" - Pastries : $2");
      Console.WriteLine();
      Console.WriteLine("We have some special deals today:");
      Console.WriteLine(" - Buy 3 breads get 1 free");
      Console.WriteLine(" - Buy 2 pastries get 1 free");
      Console.WriteLine();

      Console.WriteLine("How many of loaves of bread would you like?");
      int breadQuantity = Int32.Parse(Console.ReadLine());

      Bread breadOrder = new Bread();
      int breadOrderPrice = breadOrder.getPrice(breadQuantity);

      Console.WriteLine("How many of pastries would you like?");
      int pastryQuantity = Int32.Parse(Console.ReadLine());

      Pastry pastryOrder = new Pastry();
      int pastryOrderPrice = pastryOrder.getPrice(pastryQuantity);

      Console.WriteLine("Your order of " + breadQuantity + " loaves of bread and " + pastryQuantity + " pastries will cost $" + (breadOrderPrice + pastryOrderPrice));
    }
  }
}

