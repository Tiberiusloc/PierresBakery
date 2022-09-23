using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    private static double _Price = 2;
    private double _PastryDiscount;
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
      _PastryDiscount = 1;
    }
    public double PastryCost()
    {
      double pastryTotal = 0;
      for (int i = 0; i <= Quantity; i++)
      {
        if (i == 0)
        {
          pastryTotal += 0;
        }
        else
        {
          pastryTotal += _Price;
        }
      }
      return pastryTotal;
    }
  }
}