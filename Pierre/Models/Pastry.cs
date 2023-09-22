using System;

namespace Pierre.Models 
{
  public class Pastry 
  {
    private _numberPastries;
    public NumberPastries
    {
      get { return _numberPastries; }
    }

    private _discountNumberPastries;
    public DiscountNumberPastries
    {
      get { return _discountNumberPastries; }
    }


    public Pastry(int customerOrder)
    {
      _numberPastries = customerOrder;
      _discountNumberPastries;
    }

    public int GetPricePastry()
    {
      return _numberPastries * 2;
    }
    
    //  public int GetDiscountPastry()
    // {
    //   int[] discountPastries =  _discountNumberPastries;
    // }
  }
}