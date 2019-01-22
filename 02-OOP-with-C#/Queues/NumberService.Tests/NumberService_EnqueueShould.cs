using NUnit.Framework;
using Number.Services;

// Example tests
namespace Number.UnitTests.Services
{
  [TestFixture]
  public class NumberService_EnqueueShould
  {
    private readonly NumberService _numberService;

    public NumberService_EnqueueShould()
    {
      _numberService = new NumberService();
    }

    [Test]
    public void QueueShouldInitiallyBeEmpty()
    {
      _numberService.Reset();
      var queue = _numberService.Queue;

      CollectionAssert.IsEmpty(queue, "queue is not empty!");
    }

    [TestCase(-1)]
    [TestCase(0)]
    [TestCase(1)]
    public void EnqueueShouldAddInputToQueue(int value)
    {
      _numberService.Reset();
      var queue = _numberService.Queue;

      _numberService.Enqueue(value);

      CollectionAssert.Contains(queue, value, $"{value} has not been added to the que!");
    }

    //  Next: should add at the right place
  }
}
