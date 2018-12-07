using NUnit.Framework;
using Stack.Services;
using System.Collections.Generic;

namespace Stack.UnitTests.Services
{
  [TestFixture]
  public class StackService_PopFromStackShould
  {
    private readonly StackService _stackService;

    public StackService_PopFromStackShould()
    {
      _stackService = new StackService();
    }

    private void createStack()
    {
      _stackService.PushToStack(1);
      _stackService.PushToStack(2);
      _stackService.PushToStack(3);
    }

    [Test]
    public void ReturnTheLastItemOfTheList()
    {
      createStack();
      _stackService.PopFromStack();
      var expected = 3;
      var result = _stackService.lastItem;

      Assert.AreEqual(expected, result);
      _stackService.ResetStack();
    }

    [Test]
    public void RemoveOneItemOfTheList()
    {
      createStack(); 
      _stackService.PopFromStack();

      var expectedLength = 2;
      var result = _stackService.stack;

      Assert.AreEqual(expectedLength, result.Count);
      _stackService.ResetStack();
    }

    [Test]
    public void RemoveTheLastItemOfTheList()
    {
      createStack();
      _stackService.PopFromStack();

      var expected = new List<int>();
      expected.Add(1);
      expected.Add(2);

      var result = _stackService.stack;

      Assert.AreEqual(expected, result);
      _stackService.ResetStack();
    }

  }
}
