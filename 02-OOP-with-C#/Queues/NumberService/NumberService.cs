using System;

namespace Number.Services
{
  public class NumberService
  {
    public bool IsNumber(int candidate)
    {
      if (candidate == 1)
      {
        return true;
      }
      return false;
    }
  }
}
