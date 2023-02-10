namespace PierresBakery.Models
{
  public class MenuItem
  {
    //Price of the item
    public int Price;
    //Number of item needed to buy to get 1 free
    public int BuyXGet1Free;
    //Calculates price of order given a quantity
    public int getPrice(int orderQuantity)
    {
      return (orderQuantity - (orderQuantity / (BuyXGet1Free + 1))) * Price;
    }
    public static void ClearAll()
    {
      //do nothing
    }
  }
  //Bread subclass of MenuItem superclass
  public class Bread : MenuItem
  {
    public Bread()
    {
      Price = 5;
      BuyXGet1Free = 2;
    }
  }
  //Pastry subclass of MenuItem superclass
  public class Pastry : MenuItem
  {
    public Pastry()
    {
      Price = 2;
      BuyXGet1Free = 3;
    }
  }
}