using NUnit.Framework;
using Number.Services;

namespace Number.UnitTests.Services
{
  [TestFixture]
  public class NumberService_IsNumberShould
  {
    private readonly NumberService _numberService;

    public NumberService_IsNumberShould()
    {
      _numberService = new NumberService();
    }

    [Test]
    public void ReturnFalseGivenValueOf1()
    {
      var result = _numberService.IsNumber(1);

      Assert.True(result, "1 should be number");
    }

    [TestCase(-1)]
    [TestCase(0)]
    public void ReturnFalseGivenValuesLessThan2(int value)
    {
      var result = _numberService.IsNumber(value);

      Assert.IsFalse(result, $"{value} should not be number");
    }
  }
}
