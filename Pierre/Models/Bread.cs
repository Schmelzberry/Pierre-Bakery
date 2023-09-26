using System;

namespace Pierre.Models 
{
  public class Bread
  { 
    
    public int NumberBread { get; private set; }
   

  public Bread(int loaves)
  {
    NumberBread = loaves;
  }

  }
}