using PierresBakery.Models;
using System;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We have some special deals today:");
      Console.WriteLine(" - Buy 3 breads get 1 free");
      Console.WriteLine(" - Buy 2 pastries get 1 free");
      Console.WriteLine("Would you like to order bread or pastires today?");
      string orderType = Console.ReadLine();

      if (orderType != "bread" && orderType != "pastries")
      {
        Console.WriteLine("Sorry, we don't sell those!");
        Main();
      }
      else
      {
        Console.WriteLine("How many of those can I get for you?");
        int orderQuantity = Int32.Parse(Console.ReadLine());
        if (orderType == "bread")
        {
          Bread order = new Bread();
          int orderPrice = order.getPrice(orderQuantity);
          Console.WriteLine("Your order of " + orderQuantity + " breads will cost $" + orderPrice);

        }
        else if (orderType == "pastries")
        {
          Pastry order = new Pastry();
          int orderPrice = order.getPrice(orderQuantity);
          Console.WriteLine("Your order of " + orderQuantity + " pastries will cost $" + orderPrice);
        }
      }
    }
  }
}
