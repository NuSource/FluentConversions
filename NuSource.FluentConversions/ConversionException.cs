using System.Runtime.Serialization;

namespace NuSource.FluentConversions;

[Serializable]
public class ConversionException : ApplicationException
{
    public ConversionException(string? message) 
        : base(message) { }
    
    public ConversionException(string? message, Exception? innerException)
        : base(message, innerException) { }
    
    protected ConversionException(SerializationInfo info, StreamingContext context) 
        : base(info, context) { }
}