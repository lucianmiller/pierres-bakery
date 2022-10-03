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
  }
}