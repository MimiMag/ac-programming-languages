using System;

namespace Stack.Services
{
  public class StackService
  {
    public int[] stack;
    public bool IsStack(int candidate)
    {
      if (candidate == 1)
      {
        return false;
      }
      throw new NotImplementedException("Please create a test first");
    }

    public int[] PushToStack(int number)
    {
        return new int[1] {1};
    }
  }
}
