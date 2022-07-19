using FluentAssertions;

namespace TC.CodeCov.Spike;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Fact]
    public void Can_Add()
    {
        _calculator.Add(2, 3).Should().Be(5);
    }

    [Fact]
    public void Can_Sum()
    {
        _calculator.Sum(123, 345).Should().Be(468);
    }

    [Fact]
    public void Can_Divide()
    {
        var result = _calculator.Divide(22, 2);

        result.IsSuccess.Should().BeTrue();
        result.Value.Should().Be(11);
    }

    [Fact]
    public void Can_DivideOneLiner()
    {
        var result = _calculator.DivideOneLiner(33, 11);

        result.IsSuccess.Should().BeTrue();
        result.Value.Should().Be(3);
    }
}
