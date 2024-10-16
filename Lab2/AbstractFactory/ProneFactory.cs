namespace AbstractFactory;

public class ProneFactory : DeviceFactory
{
    public override Device CreateLaptop()
    {
        return new Laptop();
    }

    public override Device CreateNetbook()
    {
        return new Netbook();
    }

    public override Device CreateEBook()
    {
        return new EBook();
    }

    public override Device CreateSmartphone()
    {
        return new Smartphone();
    }
}