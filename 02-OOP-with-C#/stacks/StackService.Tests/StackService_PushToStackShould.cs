using NUnit.Framework;
using Stack.Services;
using System.Collections.Generic;

namespace Stack.UnitTests.Services
{
  [TestFixture]
  public class StackService_PushToStackShould
  {
    private readonly StackService _stackService;

    public StackService_PushToStackShould()
    {
      _stackService = new StackService();
    }

    private void CallPushToStackTwice(int firstNumber, int secondNumber)
    {
      _stackService.PushToStack(firstNumber);
      _stackService.PushToStack(secondNumber);
    }

    [Test]
    public void GivenValueIsPushedToStack()
    {
      _stackService.PushToStack(1);
      var result = _stackService.stack;
      var expected = new List<int>();
      expected.Add(1);

      Assert.AreEqual(expected, result);

      _stackService.ResetStack();
    }

    [Test]
    public void WhenCalledTwiceBothValuesArePushedToStack() 
    {
      CallPushToStackTwice(1, 2);

      var result = _stackService.stack;
      var expected = new List<int>();
      expected.Add(1);
      expected.Add(2);

      Assert.AreEqual(expected, result);

      _stackService.ResetStack();
    }

  }
}
