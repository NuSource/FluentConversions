using FluentConversions.Enums;
using FluentConversions.Types;

namespace FluentConversions;

public static class FluentConvert
{
    public static Temperature FromTemperature(double value, TemperatureType type)
    {
        return new Temperature(value, type);
    }
    
    public static Distance FromDistance(double value, DistanceType type)
    {
        return new Distance(value, type);
    }
    
    public static Time FromTime(double value, TimeType type)
    {
        return new Time(value, type);
    }
}