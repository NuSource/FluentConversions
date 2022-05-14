using NuSource.FluentConversions.Enums;

namespace NuSource.FluentConversions.Types;

public class Temperature
{
    private readonly double _fromCelsius;

    internal Temperature(double value, TemperatureType fromType)
    {
        _fromCelsius = fromType switch
        {
            TemperatureType.Celsius => 
                value,
            TemperatureType.Fahrenheit => 
                (value - 32.0) * (5.0/ 9.0),
            TemperatureType.Kelvin => 
                value - 273.15,
            _ => throw new ConversionException("Invalid from temperature type.")
        };
    }

    public double To(TemperatureType toType)
    {
        return toType switch
        {
            TemperatureType.Celsius =>
                _fromCelsius,
            TemperatureType.Fahrenheit =>
                (_fromCelsius * (9.0 / 5.0)) + 32.0,
            TemperatureType.Kelvin =>
                _fromCelsius + 273.15,
            _ => throw new ConversionException("Invalid to temperature type.")
        };
    }
}