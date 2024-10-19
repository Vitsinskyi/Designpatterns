namespace Decorator;

public class WeaponDecorator : HeroDecorator
{
    public WeaponDecorator(Hero hero) : base(hero) { }

    public override void Attack()
    {
        Console.WriteLine("Weapon equipped.");
        base.Attack();
    }
}
