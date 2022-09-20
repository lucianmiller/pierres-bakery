using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int AmountBought { get; set; }
    public int CurrentPrice { get; set; }


  public Bread(int userBought, int currentPrice)
  {
    AmountBought = userBought;
    CurrentPrice = currentPrice;
  }
  }
}