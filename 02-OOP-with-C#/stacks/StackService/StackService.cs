using System;
using System.Collections.Generic;

namespace Stack.Services
{
  public class StackService
  {
    public List<int> stack = new List<int>();

    public void PushToStack(int number)
    {
        stack.Add(number);
    }

    public void ResetStack()
    {
        stack = new List<int>();
    }

    private int ReturnLastItemIndex()
    {
      return stack.Count - 1;
    }

    public int PopFromStack()
    {
        var lastItemIndex = ReturnLastItemIndex();
        var lastItemValue = stack[lastItemIndex]; 
        stack.RemoveAt(lastItemIndex);
        return lastItemValue;
    }

    public void PopAllItems()
    {
        
    }

  }
}
