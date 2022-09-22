using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int AmountBought { get; set; }
    public int CurrentPrice { get; set; }


  public Bread(int userBought)
  {
    AmountBought = userBought;
    CurrentPrice = 0;
  }

  public void BreadPrice()
  {
    this.CurrentPrice = this.AmountBought * 5;
  }
  }
}