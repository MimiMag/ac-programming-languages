using NUnit.Framework;
using Stack.Services;
using System.Collections.Generic;

namespace Stack.UnitTests.Services
{
  [TestFixture]
  public class StackService_PopFromStackShould
  {
    private StackService _stackService;

    [SetUp]
    public void SetUp()
    {
      _stackService = new StackService();
      CreateStack();
    }

    private void CreateStack()
    {
      _stackService.PushToStack(1);
      _stackService.PushToStack(2);
      _stackService.PushToStack(3);
    }

    [Test]
    public void ReturnTheLastItemOfTheList()
    {
  
      var expected = 3;
      var result = _stackService.PopFromStack();

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void RemoveOneItemOfTheList()
    {
      _stackService.PopFromStack();

      var expectedLength = 2;
      var result = _stackService.stack;

      Assert.AreEqual(expectedLength, result.Count);
    }

    [Test]
    public void RemoveTheLastItemOfTheList()
    {
      _stackService.PopFromStack();

      var expected = new List<int>();
      expected.Add(1);
      expected.Add(2);

      var result = _stackService.stack;

      Assert.AreEqual(expected, result);
    }

  }
}
