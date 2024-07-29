namespace ClassLibrary;

public static class Validator
{
    public static void ValidateNotNull(object obj, string paramName)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(paramName, $"{paramName} cannot be null.");
        }
    } 
    
    public static void ValidateNotNullOrEmpty(string value, string paramName)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Value cannot be null or empty.", paramName);
        }
    }
    
    public static void ValidateGreaterThanZero(int value, string paramName)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(paramName, $"{paramName} must be greater than zero.");
        }
    }
    
    public static void ValidateNonNegative(int value, string paramName)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(paramName, $"{paramName} cannot be negative.");
        }
    }
}