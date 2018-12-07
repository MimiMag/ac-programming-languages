using NUnit.Framework;
using Stack.Services;

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

    [Test]
    public void GivenValueIsPushedToStack()
    {
      var result = _stackService.PushToStack(1);
      var expected = new int[1] {1};

      Assert.AreEqual(result, expected);
    }

  }
}
