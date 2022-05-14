using System.Security.Cryptography;
using FluentAssertions;
using NuSource.FluentConversions.Enums;
using Xunit;

namespace NuSource.FluentConversions.Test;

public class TimeConversionShould
{
    [Theory]
    [InlineData(0.0, 0.0)]
    [InlineData(1.0, 31557600000.0)]
    [InlineData(50.0, 1577880000000.0)]
    [InlineData(100.0, 3155760000000.0)]
    public void YearsToMilliseconds(double inputYears, double expectedMilliseconds)
    {
        FluentConvert
            .FromTime(inputYears, TimeType.Years)
            .To(TimeType.Milliseconds)
            .Should().BeApproximately(expectedMilliseconds, 0.00001);
    }
    
    [Theory]
    [InlineData(0.0, 0.0)]
    [InlineData(1.0, 0.1428571429)]
    [InlineData(50.0, 7.1428571429)]
    [InlineData(100.0, 14.2857142857)]
    public void DaysToWeeks(double inputDays, double expectedWeeks)
    {
        FluentConvert
            .FromTime(inputDays, TimeType.Days)
            .To(TimeType.Weeks)
            .Should().BeApproximately(expectedWeeks, 0.00001);
    }
}