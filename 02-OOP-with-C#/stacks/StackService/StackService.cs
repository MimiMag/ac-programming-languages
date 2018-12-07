using System;
using System.Collections.Generic;

namespace Stack.Services
{
  public class StackService
  {
    public List<int> stack = new List<int>();
    public int lastItem;

    public void PushToStack(int number)
    {
        stack.Add(number);
    }

    public void ResetStack()
    {
        stack = new List<int>();
    }

    private void AssignLastItem()
    {
      lastItem = stack[stack.Count - 1];
    }

    public void PopFromStack()
    {
        AssignLastItem();
        stack.RemoveAt(stack.Count - 1);
    }

    public void PopAllItems()
    {
        
    }

  }
}
