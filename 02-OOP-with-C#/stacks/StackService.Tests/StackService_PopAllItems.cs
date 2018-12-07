using NUnit.Framework;
using Stack.Services;
using System.Collections.Generic;

namespace Stack.UnitTests.Services
{
  [TestFixture]
  public class StackService_PopAllItemsShould
  {
    private readonly StackService _stackService;

    public StackService_PopAllItemsShould()
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
      _stackService.PopAllItems();
      // var expected = 3;
      // var result = _stackService.lastItem;

      // Assert.AreEqual(expected, result);
      // _stackService.ResetStack();
    }
  }
}
