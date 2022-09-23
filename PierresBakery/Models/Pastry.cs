using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    private static double _Price = 2;
    private double _DealOne;
    private double _DealTwo;
    public int Quantity { get; set; }
    public static double Price
    {
      get { return _Price; }
      set { _Price = value ;}
    }
    public Pastry(int quantity)
    {
      Quantity = quantity;
      _Price = Price;
      _DealOne = 1;
      _DealTwo = 2;
    }
  }
}