namespace Decorator;

public abstract class HeroDecorator(Hero hero) : Hero
{
    private Hero _hero = hero;

    public override void Attack()
    {
        _hero.Attack();
    }
}