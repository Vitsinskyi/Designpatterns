namespace Decorator;

public class Warrior : Hero
{
    public override void Attack()
    {
        Console.WriteLine("Warrior attacks!");
    }
}