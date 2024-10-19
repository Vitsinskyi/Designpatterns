namespace Decorator;

public class Mage : Hero
{
    public override void Attack()
    {
        Console.WriteLine("Mage casts a spell!");
    }
}