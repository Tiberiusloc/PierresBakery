using System;
using System.Collections.Generic;
using System.Linq;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("A loaf of bread costs $5 and a pastry is $2.");
      Console.WriteLine("For every 2 loaves of bread, you get the 3rd free!");
      Console.WriteLine("Pastry Deals: 3 pastries for $5, 4 pastries for $7, 5 pastries for $9, 6 pastries for $10");
      Console.WriteLine("Enter how many loaves of bread you would like to purchase");

      int userBreadOrder = int.Parse(Console.ReadLine());
      Bread userBread = new Bread(userBreadOrder);
      Console.WriteLine(userBread.BreadCost());
    }
    
  }
}