using FluentConversions.Enums;

namespace FluentConversions.Types;

public class Distance
{
    private readonly double _fromMeters;

    internal Distance(double value, DistanceType fromType)
    {
        _fromMeters = fromType switch
        {
            // Imperial
            DistanceType.Inches => 
                value / 39.3700787402,
            DistanceType.Feet =>
                value / 3.280839895,
            DistanceType.Yards =>
                value / 1.0936132983,
            DistanceType.Miles =>
                value / 0.0006213712,
            DistanceType.NauticalMiles =>
                value / 0.0005399568,
    
            // Metric
            DistanceType.Yotameters =>
                value * 10000000000.0,
            DistanceType.Zetameters =>
                value * 1000000000.0,
            DistanceType.Exameters =>
                value * 100000000.0,
            DistanceType.Petameters =>
                value * 10000000.0,
            DistanceType.Terameters =>
                value * 1000000.0,
            DistanceType.Gigameters =>
                value * 100000.0,
            DistanceType.Megameters =>
                value * 10000.0,
            DistanceType.Kilometers =>
                value * 1000.0,
            DistanceType.Hectometers =>
                value * 100.0,
            DistanceType.Decameters =>
                value * 10.0,
            DistanceType.Meters => 
                value,
            DistanceType.Decimeters =>
                value / 10.0,
            DistanceType.Centimeters =>
                value / 100.0,
            DistanceType.Millimeters =>
                value / 1000.0,
            DistanceType.Micrometers =>
                value / 10000.0,
            DistanceType.Nanometers =>
                value / 100000.0,
            DistanceType.Picometers =>
                value / 1000000.0,
            DistanceType.Femtometers =>
                value / 10000000.0,
            DistanceType.Attometers =>
                value / 100000000.0,
            DistanceType.Zeptometers =>
                value / 1000000000.0,
            DistanceType.Yoctometers =>
                value / 10000000000.0,
            _ => throw new ConversionException("Invalid from distance type.")
        };
    }

    public double To(DistanceType toType)
    {
        return toType switch
        {
            // Imperial
            DistanceType.Inches => 
                _fromMeters * 39.3700787402,
            DistanceType.Feet =>
                _fromMeters * 3.280839895,
            DistanceType.Yards =>
                _fromMeters * 1.0936132983,
            DistanceType.Miles =>
                _fromMeters * 0.0006213712,
            DistanceType.NauticalMiles =>
                _fromMeters * 0.0005399568,
    
            // Metric
            DistanceType.Yotameters =>
                _fromMeters / 10000000000.0,
            DistanceType.Zetameters =>
                _fromMeters / 1000000000.0,
            DistanceType.Exameters =>
                _fromMeters / 100000000.0,
            DistanceType.Petameters =>
                _fromMeters / 10000000.0,
            DistanceType.Terameters =>
                _fromMeters / 1000000.0,
            DistanceType.Gigameters =>
                _fromMeters / 100000.0,
            DistanceType.Megameters =>
                _fromMeters / 10000.0,
            DistanceType.Kilometers =>
                _fromMeters / 1000.0,
            DistanceType.Hectometers =>
                _fromMeters / 100.0,
            DistanceType.Decameters =>
                _fromMeters / 10.0,
            DistanceType.Meters => 
                _fromMeters,
            DistanceType.Decimeters =>
                _fromMeters * 10.0,
            DistanceType.Centimeters =>
                _fromMeters * 100.0,
            DistanceType.Millimeters =>
                _fromMeters * 1000.0,
            DistanceType.Micrometers =>
                _fromMeters * 10000.0,
            DistanceType.Nanometers =>
                _fromMeters * 100000.0,
            DistanceType.Picometers =>
                _fromMeters * 1000000.0,
            DistanceType.Femtometers =>
                _fromMeters * 10000000.0,
            DistanceType.Attometers =>
                _fromMeters * 100000000.0,
            DistanceType.Zeptometers =>
                _fromMeters * 1000000000.0,
            DistanceType.Yoctometers =>
                _fromMeters * 10000000000.0,
            _ => throw new ConversionException("Invalid to distance type.")
        };
    }
}