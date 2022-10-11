using System;
using PierresBakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("How many loafs of bread do you want?");
    string breadOrder = Console.ReadLine();
    int breadOrderNum = int.Parse(breadOrder);
    Bread newBread = new Bread(breadOrderNum);
    newBread.BreadPrice();
    int breadCost = newBread.CurrentPrice;
    Console.WriteLine($"Your amount for bread is ${breadCost}.");
    
    Console.WriteLine("How many pastries do you want?");
    string pastryOrder = Console.ReadLine();
    int pastryOrderNum = int.Parse(pastryOrder);
    Pastry newPastry = new Pastry(pastryOrderNum);
    newPastry.PastryPrice();
    int pastryCost = newPastry.CurrentPrice;
    Console.WriteLine($"Your amount for pastries is ${pastryCost}.");
    
    int totalPrice = pastryCost + breadCost;
    Console.WriteLine($"Your total is ${totalPrice}");
    Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
  }
}