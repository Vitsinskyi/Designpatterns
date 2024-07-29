using System.Text;
using ClassLibrary;

namespace ConsoleApp;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        
        ICurrency dollar = new Dollar();
        ICurrency euro = new Euro();

        Money money1 = new Money(100, 50, dollar);
        Money money2 = new Money(200, 25, euro);

        Product product = new Product("Продукт 1", money1);
        Console.WriteLine($"Ціна продукту {product.Name}: {product.Price.GetWholePart()}.{product.Price.GetFractionalPart()} {product.Price.Currency.Symbol}");

        product.ReducePrice(10);
        Console.WriteLine($"Нова ціна продукту {product.Name}: {product.Price.GetWholePart()}.{product.Price.GetFractionalPart()} {product.Price.Currency.Symbol}");

        Warehouse warehouse = new Warehouse();

        WarehouseItem warehouseItem = new WarehouseItem("Товар 1", "шт", money1, 10, DateTime.Now);

        WarehouseItem warehouseItem2 = new WarehouseItem("Товар 2", "шт", money2, 20, DateTime.Now);

        warehouse.AddItem(warehouseItem);
        Console.WriteLine($"Товар {warehouseItem.Name} додано на склад.");
        
        warehouse.AddItem(warehouseItem2);
        Console.WriteLine($"Товар {warehouseItem2.Name} додано на склад.");

        Reporting reporting = new Reporting(warehouse);

        reporting.RegisterArrival(warehouseItem);
        Console.WriteLine($"Товар {warehouseItem.Name} зареєстровано як отриманий.");
        
        reporting.RegisterArrival(warehouseItem2);
        Console.WriteLine($"Товар {warehouseItem2.Name} зареєстровано як отриманий.");
        
        reporting.RegisterDeparture(warehouseItem, 3);
        Console.WriteLine($"Товар {warehouseItem.Name} зареєстровано як відправлений.");

        reporting.InventoryReport();
    }
}