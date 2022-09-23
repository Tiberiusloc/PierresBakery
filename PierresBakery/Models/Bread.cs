using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    private static double _Price = 5;
    private double _Discount;
    public int Quantity { get; set; }
    public static double Price
    {
      get { return _Price; }
      set { _Price = value ;}
    }
    public Bread(int quantity)
    {
      Quantity = quantity;
      _Price = Price;
      _Discount = 0;
    }
    public double BreadCost()
    {
      double breadTotal = 0;
      for (int i = 0; i <= Quantity; i++)
      {
        if (i == 0)
        {
          breadTotal += 0;
        }
        else if(i % 3 == 0 )
        {
          breadTotal += _Price * _Discount;
        }
        else 
        {
          breadTotal += _Price;
        }
      }
      return breadTotal;
    }
  }
}