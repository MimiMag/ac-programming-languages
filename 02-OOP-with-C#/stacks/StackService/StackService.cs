using System;
using System.Collections.Generic;

namespace Stack.Services
{
  public class StackService
  {
    public List<int> stack = new List<int>();

    public bool IsStack(int candidate)
    {
      if (candidate == 1)
      {
        return false;
      }
      throw new NotImplementedException("Please create a test first");
    }

    public void PushToStack(int number)
    {
        stack.Add(number);
    }
  }
}
