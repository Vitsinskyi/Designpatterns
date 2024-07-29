namespace ClassLibrary;

public class Product : IProduct
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        Validator.ValidateNotNullOrEmpty(name, nameof(name));
        Validator.ValidateNotNull(price, nameof(price));

        Name = name;
        Price = price;
    }

    public void ReducePrice(int amount)
    {
        Validator.ValidateNonNegative(amount, nameof(amount));

        if (Price.GetWholePart() < amount)
        {
            throw new InvalidOperationException("Cannot reduce price below zero.");
        }

        var newPrice = Price.GetWholePart() - amount ; 

        Price.SetWholePart(newPrice);
    }
}