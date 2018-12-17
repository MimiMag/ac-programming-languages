using NUnit.Framework;
using Stack.Services;

namespace Stack.UnitTests.Services
{
  [TestFixture]
  public class StackService_bug01
  {
    [Test]
    public void TestTheBug()
    {
      // arrange
      var stack = new StackService();
      stack.PushToStack(1);
      stack.PushToStack(2);
      stack.PushToStack(3);
      stack.PushToStack(4);
      stack.PushToStack(5);

      int[] result = stack.PopAllItemsAndReturnResult();

      // assert
      Assert.AreEqual(5, result[0]);
      Assert.AreEqual(4, result[1]);
      Assert.AreEqual(3, result[2]);
      Assert.AreEqual(2, result[3]);
      Assert.AreEqual(1, result[4]);
    }
  }
}
