# FluentConversions [![NuGet Publish](https://github.com/NuSource/FluentConversions/actions/workflows/nuget-publish.yml/badge.svg)](https://github.com/NuSource/FluentConversions/actions/workflows/nuget-publish.yml)

NuGet package link: https://www.nuget.org/packages/NuSource.FluentConversions/

## About
Simple and fluent conversions for various units.

```csharp
double inc = FluentConvert.FromDistance(3.0, DistanceType.Meters).To(DistanceType.Inches);
Console.WriteLine($"3 meters is {inc} inches."); // 3 meters is 118.1102362206 inches.

double c = FluentConvert.FromTemperature(32.0, TemperatureType.Fahrenheit).To(TemperatureType.Celsius);
Console.WriteLine($"32f is {c}c."); // 32f is 0c.
```

Full documentation can be found on the GitHub wiki: https://github.com/NuSource/FluentConversions/wiki

## Contributing
All contributor branches should track the `develop` branch, and the `main` branch is only for releases.
