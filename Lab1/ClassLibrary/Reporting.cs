using System.Text;

namespace ClassLibrary;

public class Reporting
{
    private Warehouse _warehouse;

    public Reporting(Warehouse warehouse)
    {
        _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse), "Warehouse cannot be null.");
    }

    public void RegisterArrival(WarehouseItem item)
    {
        Validator.ValidateNotNull(item, nameof(item));

        _warehouse.AddItem(item);
        Console.WriteLine($"Прибуткова накладна: {item.Name}, {item.Quantity} {item.UnitOfMeasure}");
    }

    public void RegisterDeparture(WarehouseItem item, int quantity)
    {
        Validator.ValidateNotNull(item, nameof(item));
        Validator.ValidateGreaterThanZero(quantity, nameof(quantity));
        
        ValidateItemInWarehouse(item);

        if (item.Quantity < quantity)
        {
            throw new InvalidOperationException("Not enough items in warehouse.");
        }

        item.Quantity -= quantity;
        Console.WriteLine($"Видаткова накладна: {item.Name}, {quantity} {item.UnitOfMeasure}");
    }

    public void InventoryReport()
    {
        Console.WriteLine("Звіт по інвентаризації:");
        foreach (var item in _warehouse.Items)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(item.Name)
                .Append(", ")
                .Append(item.Quantity)
                .Append(" ")
                .Append(item.UnitOfMeasure)
                .Append(", ")
                .Append(item.PricePerUnit.GetWholePart())
                .Append(".")
                .Append(item.PricePerUnit.GetFractionalPart())
                .Append(" ")
                .Append(item.PricePerUnit.Currency.Symbol)
                .Append(", ")
                .Append(item.LastDeliveryDate);

            Console.WriteLine(sb.ToString());
        }
    }
    
    private void ValidateItemInWarehouse(WarehouseItem item)
    {
        if (!_warehouse.Items.Contains(item))
        {
            throw new InvalidOperationException("Item not found in warehouse.");
        }
    }
}