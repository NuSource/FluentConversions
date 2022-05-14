namespace FluentConversions;

public class ConversionException : ApplicationException
{
    public ConversionException(string message) 
        : base(message)
    {
        
    }
}