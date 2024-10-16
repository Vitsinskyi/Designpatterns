using System.Text;

namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        DeviceFactory factory = new ProneFactory();
        Device device = factory.CreateLaptop();
        sb.AppendLine($"Created {device.Name} with {factory.GetType().Name}");

        factory = new KiaomiFactory();
        device = factory.CreateNetbook();
        sb.AppendLine($"Created {device.Name} with {factory.GetType().Name}");

        factory = new BalaxyFactory();
        device = factory.CreateSmartphone();
        sb.AppendLine($"Created {device.Name} with {factory.GetType().Name}");

        Console.WriteLine(sb.ToString());
    }
}