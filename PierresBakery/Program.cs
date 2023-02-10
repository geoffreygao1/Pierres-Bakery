using PierresBakery.Models;
using System;

namespace PierresBakery
{
  public class Program
  {
    private static Order _yourOrder { get; set; }
    private static int _breadQuantity = 0;
    private static int _pastryQuantity = 0;
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine();
      Console.WriteLine("Today's Menu:");
      Console.WriteLine(" - Bread : $5");
      Console.WriteLine(" - Pastries : $2");
      Console.WriteLine();
      Console.WriteLine("We have some special deals today:");
      Console.WriteLine(" - Buy 3 breads get 1 free");
      Console.WriteLine(" - Buy 2 pastries get 1 free");
      Console.WriteLine();
      _yourOrder = new Order();
      startOrder();
    }
    public static void startOrder()
    {
      Console.WriteLine("Would you like to order bread or pastries?");
      string response = Console.ReadLine();
      if (response != "bread" && response != "pastries")
      {
        Console.WriteLine("Sorry, we don't have that");
        startOrder();
      }
      else if (response == "bread")
      {
        addBread();
      }
      else
      {
        addPastry();
      }
    }
    public static void addBread()
    {
      Console.WriteLine("How many loaves of bread would you like?");
      int breadQuantity = Int32.Parse(Console.ReadLine());
      _breadQuantity += breadQuantity;
      Bread breadOrder = new Bread();
      _yourOrder.addToOrder(breadOrder, breadQuantity);
      Console.WriteLine("Sure! I've added " + breadQuantity + " loaves of bread to your order");
      continueOrder();
    }
    public static void addPastry()
    {
      Console.WriteLine("How many pastries would you like?");
      int pastryQuantity = Int32.Parse(Console.ReadLine());
      _pastryQuantity += pastryQuantity;
      Pastry pastryOrder = new Pastry();
      _yourOrder.addToOrder(pastryOrder, pastryQuantity);
      Console.WriteLine("Sure! I've added " + pastryQuantity + " pastries to your order");
      continueOrder();
    }
    public static void continueOrder()
    {
      Console.WriteLine("Is there anything else you'd like to your order?");
      string response = Console.ReadLine();
      if (response == "yes")
      {
        startOrder();
      }
      else if (response == "no")
      {
        checkout();
      }
      else
      {
        Console.WriteLine("Sorry, I'm not sure I understood that");
        continueOrder();
      }
    }
    public static void checkout()
    {
      int finalPrice = _yourOrder.getOrderPrice();
      Console.WriteLine("Your order of " + _breadQuantity + " loaves of bread and " + _pastryQuantity + " pastries will cost $" + finalPrice);
      Console.WriteLine("Thanks and come again!");
    }
  }
}

