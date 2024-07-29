namespace ClassLibrary;

public class Warehouse(List<WarehouseItem> items)
{
    public List<WarehouseItem> Items { get; set; } = items;

    public Warehouse() : this(new List<WarehouseItem>())
    {
    }

    public void AddItem(WarehouseItem item)
    {
        Validator.ValidateNotNull(item, nameof(item));

        if (!Items.Contains(item))
        {
            Items.Add(item);
        }
    }
}