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
      int i = this.AmountBought;
      while (i > 0)
      {
        if (i % 3 == 0)
        {
          this.CurrentPrice += 0;
        }
        else
        {
          this.CurrentPrice += 5;
        }
        i--;
      }
    }
  }
}