using NUnit.Framework;
using Stack.Services;

namespace Stack.UnitTests.Services
{
  [TestFixture]
  public class StackService_IsStackShould
  {
    private readonly StackService _stackService;

    public StackService_IsStackShould()
    {
      _stackService = new StackService();
    }

    [Test]
    public void ReturnFalseGivenValueOf1()
    {
      var result = _stackService.IsStack(1);

      Assert.IsFalse(result, "1 should not be stack");
    }
  }
}
