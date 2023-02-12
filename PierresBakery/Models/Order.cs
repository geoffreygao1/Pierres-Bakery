using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Order
  {
    private static Dictionary<MenuItem, int> _instances = new Dictionary<MenuItem, int>() { };
    public Order()
    {

    }
    //Adds menu item to order dictionary
    public void addToOrder(MenuItem orderEntry, int quantity)
    {
      _instances.Add(orderEntry, quantity);
    }
    //Returns sum total of each menuItem price given quantity
    public int getOrderPrice()
    {
      int total = 0;
      foreach (KeyValuePair<MenuItem, int> instance in _instances)
      {
        total += instance.Key.getPrice(instance.Value);
      }
      return total;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}