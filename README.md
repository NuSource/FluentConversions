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
### Questions/Discussions
Please feel free to open an issue if you have any questions or would like to discuss any thing about this project. I would love to hear feedback from folks checking this out!

### Issues
The versioning of this application conforms to [Semantic Versioning](https://semver.org), however because this is currently a one man project I can only support the latest version of the package. If you run into any issues please try updating to the latest available version before opening an issue.

### Pull Requests
All contributor branches should track the `develop` branch, and the `main` branch is only for releases.
