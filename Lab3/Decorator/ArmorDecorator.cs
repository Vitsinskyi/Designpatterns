namespace Decorator;

public class ArmorDecorator : HeroDecorator
{
    public ArmorDecorator(Hero hero) : base(hero) { }

    public override void Attack()
    {
        Console.WriteLine("Armor equipped.");
        base.Attack();
    }
}