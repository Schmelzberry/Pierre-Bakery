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
      return _numberPastries * 2;
    }
  }
}