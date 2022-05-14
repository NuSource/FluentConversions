using FluentConversions.Enums;

namespace FluentConversions.Types;

public class Time
{
    private readonly double _fromMilliseconds;

    internal Time(double value, TimeType fromType)
    {
        _fromMilliseconds = fromType switch
        {
            TimeType.Years =>
                value * 31557600000,
            TimeType.Months =>
                value * 2629800000,
            TimeType.Weeks =>
                value * 604800000,
            TimeType.Days =>
                value * 86400000,
            TimeType.Hours =>
                value * 3600000,
            TimeType.Minutes =>
                value * 60000,
            TimeType.Seconds => 
                value * 1000,
            TimeType.Milliseconds => 
                value,
            _ => throw new ConversionException("Invalid from time type.")
        };
    }

    public double To(TimeType toType)
    {
        return toType switch
        {
            TimeType.Years =>
                _fromMilliseconds / 31557600000,
            TimeType.Months =>
                _fromMilliseconds / 2629800000,
            TimeType.Weeks =>
                _fromMilliseconds / 604800000,
            TimeType.Days =>
                _fromMilliseconds / 86400000,
            TimeType.Hours =>
                _fromMilliseconds / 3600000,
            TimeType.Minutes =>
                _fromMilliseconds / 60000,
            TimeType.Seconds => 
                _fromMilliseconds / 1000,
            TimeType.Milliseconds => 
                _fromMilliseconds,
            _ => throw new ConversionException("Invalid from time type.")
        };
    }
}