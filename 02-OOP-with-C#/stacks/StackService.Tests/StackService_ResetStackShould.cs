using NUnit.Framework;
using Stack.Services;
using System.Collections.Generic;

namespace Stack.UnitTests.Services
{
  [TestFixture]
  public class StackService_ResetStackShould
  {
    private readonly StackService _stackService;

    public StackService_ResetStackShould()
    {
      _stackService = new StackService();
    }

    [Test]
    public void ResetStack()
    {
      _stackService.ResetStack();

      var result = _stackService.stack;
      var expected = new List<int>();

      Assert.AreEqual(expected, result);

      _stackService.ResetStack();
    }

  }
}
