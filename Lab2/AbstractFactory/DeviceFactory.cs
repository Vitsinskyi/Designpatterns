namespace AbstractFactory;

public abstract class DeviceFactory
{
    public abstract Device CreateLaptop();
    public abstract Device CreateNetbook();
    public abstract Device CreateEBook();
    public abstract Device CreateSmartphone();
}