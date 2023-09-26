using System;
namespace Pierre.Models 
{
  public class Pastry 
  {
    private int _numberPastries;
    public int NumberPastries
    {
      get { return _numberPastries; }
    }
    public Pastry(int customerOrder)
    {
      _numberPastries = customerOrder;
    }

 public int GetPricePastry()
{
    int pricePerPastry = 2; // Price per pastry without discount
    int discountedPrice = 0;
    
    // Calculate the total price with the discount
    if (_numberPastries > 0)
    {
        int discountedPastries = _numberPastries / 4;
        int remainingPastries = _numberPastries % 4;

        discountedPrice = (discountedPastries * 3 * pricePerPastry) + (remainingPastries * pricePerPastry);
    }

    return discountedPrice;
}
}
}