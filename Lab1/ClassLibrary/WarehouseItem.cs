namespace ClassLibrary;

public class WarehouseItem
{
    public string Name { get; set; }
    public string UnitOfMeasure { get; set; }
    public Money PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public DateTime LastDeliveryDate { get; set; }

    public WarehouseItem(string name, string unitOfMeasure, Money pricePerUnit, int quantity, DateTime lastDeliveryDate)
    {
        Validator.ValidateNotNullOrEmpty(name, nameof(name));

        Validator.ValidateNotNullOrEmpty(unitOfMeasure, nameof(unitOfMeasure));
        
        Validator.ValidateNotNull(pricePerUnit, nameof(pricePerUnit));

        Validator.ValidateNonNegative(quantity, nameof(quantity));

        Name = name;
        UnitOfMeasure = unitOfMeasure;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
        LastDeliveryDate = lastDeliveryDate;
    }
}