namespace ClassLibrary;

public class Money
{
    private int _wholePart;
    private int _fractionalPart;
    private ICurrency _currency;

    public Money(int wholePart, int fractionalPart, ICurrency currency)
    {
        _wholePart = wholePart;
        _fractionalPart = fractionalPart;
        _currency = currency;
    }

    public void Display()
    {
        Console.WriteLine($"Сума: {_currency.Symbol}{_wholePart}.{_fractionalPart}");
    }

    public void SetWholePart(int value)
    {
        _wholePart = value;
    }

    public void SetFractionalPart(int value)
    {
        _fractionalPart = value;
    }

    public int GetWholePart()
    {
        return _wholePart;
    }

    public int GetFractionalPart()
    {
        return _fractionalPart;
    }

    public ICurrency Currency
    {
        get { return _currency; }
    }
}