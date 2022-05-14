using FluentAssertions;
using NuSource.FluentConversions.Enums;
using Xunit;

namespace NuSource.FluentConversions.Test;

public class TemperatureConversionShould
{
    [Theory]
    [InlineData(0.0, 255.3722222222)]
    [InlineData(1.0, 255.9277777778)]
    [InlineData(50.0, 283.15)]
    [InlineData(100.0, 310.9277777778)]
    public void FahrenheitToKelvin(double inputFahrenheit, double expectedKelvin)
    {
        FluentConvert
            .FromTemperature(inputFahrenheit, TemperatureType.Fahrenheit)
            .To(TemperatureType.Kelvin)
            .Should().BeApproximately(expectedKelvin, 0.00001);
    }
    
    [Theory]
    [InlineData(0.0, -459.67)]
    [InlineData(1.0, -457.87)]
    [InlineData(50.0, -369.67)]
    [InlineData(100.0, -279.67)]
    public void KelvinToFahrenheit(double inputKelvin, double expectedFahrenheit)
    {
        FluentConvert
            .FromTemperature(inputKelvin, TemperatureType.Kelvin)
            .To(TemperatureType.Fahrenheit)
            .Should().BeApproximately(expectedFahrenheit, 0.00001);
    }
}