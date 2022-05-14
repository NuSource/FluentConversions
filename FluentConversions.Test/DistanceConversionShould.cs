using FluentAssertions;
using FluentConversions.Enums;
using Xunit;

namespace FluentConversions.Test;

public class DistanceConversionShould
{
    [Theory]
    [InlineData(0.0, 0.0)]
    [InlineData(1.0, 0.0254)]
    [InlineData(50.0, 1.27)]
    [InlineData(100.0, 2.54)]
    public void InchesToMeters(double inputInches, double expectedMeters)
    {
        FluentConvert
            .FromDistance(inputInches, DistanceType.Inches)
            .To(DistanceType.Meters)
            .Should().BeApproximately(expectedMeters, 0.00001);
    }

    [Theory]
    [InlineData(0.0, 0.0)]
    [InlineData(1.0, 1000.0)]
    [InlineData(50.0, 50000.0)]
    [InlineData(100.0, 100000.0)]
    public void KilometersToMeters(double inputKilometers, double expectedMeters)
    {
        FluentConvert
            .FromDistance(inputKilometers, DistanceType.Kilometers)
            .To(DistanceType.Meters)
            .Should().BeApproximately(expectedMeters, 0.00001);
    }
    
    [Theory]
    [InlineData(0.0, 0.0)]
    [InlineData(1.0, 39370.07874)]
    [InlineData(50.0, 1968503.93701)]
    [InlineData(100.0, 3937007.87402)]
    public void KilometersToInches(double inputKilometers, double expectedInches)
    {
        FluentConvert
            .FromDistance(inputKilometers, DistanceType.Kilometers)
            .To(DistanceType.Inches)
            .Should().BeApproximately(expectedInches, 0.00001);
    }
    
    [Theory]
    [InlineData(0.0, 0.0)]
    [InlineData(1.0, 12.0)]
    [InlineData(50.0, 600.0)]
    [InlineData(100.0, 1200.0)]
    public void FeetToInches(double inputFeet, double expectedInches)
    {
        FluentConvert
            .FromDistance(inputFeet, DistanceType.Feet)
            .To(DistanceType.Inches)
            .Should().BeApproximately(expectedInches, 0.00001);
    }
}