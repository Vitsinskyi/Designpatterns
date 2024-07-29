namespace ClassLibrary;

public interface IProduct
{
    string Name { get; set; }
    Money Price { get; set; }
    void ReducePrice(int amount);
}