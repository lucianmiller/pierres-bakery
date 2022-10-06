using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int AmountBought { get; set; }
    public int CurrentPrice { get; set; }

    public Pastry(int userBought)
    {
      AmountBought = userBought;
      CurrentPrice = 0;
    }

    public void PastryPrice()
    {
      int i = this.AmountBought;
      while (i > 0)
      {
        if (i % 3 == 0)
        {
          this.CurrentPrice += 1;
        }
        else
        {
          this.CurrentPrice += 2;
        }
      i--;
      }
    }
  }
}