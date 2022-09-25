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
      Console.WriteLine("Bread Deals: For every 2 loaves of bread, you get the 3rd free!");
      Console.WriteLine("Pastry Deals: 3 pastries for $5, 4 pastries for $7, 5 pastries for $9, 6 pastries for $10");
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Enter how many loaves of bread you would like to purchase: ");

      int userBreadOrder = int.Parse(Console.ReadLine());
      Bread userBread = new Bread(userBreadOrder);
      double userBreadTotal = userBread.BreadCost();
      Console.WriteLine("The total cost of your bread order is $" + userBreadTotal);
      Console.WriteLine("-------------------------------------");

      Console.WriteLine("Enter how many pastries you'd like to purchase: ");

      int userPastryOrder = int.Parse(Console.ReadLine());
      Pastry userPastry = new Pastry(userPastryOrder);
      double userPastryTotal = userPastry.PastryCost();
      Console.WriteLine("The total cost of your pastry order is $" + userPastryTotal);

      Console.WriteLine("-------------------------------------");
      double userTotalCost = userBreadTotal + userPastryTotal;
      Console.WriteLine("The cost of your entire order is $" + userTotalCost);
      Console.WriteLine("-------------------------------------");

      Console.WriteLine("Thank you for being a valued customer of Pierre's Bakery!");
      Console.WriteLine("Recommend us to your friends and family and have a great day!");
    }    
  }
}