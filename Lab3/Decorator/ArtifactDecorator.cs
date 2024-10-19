namespace Decorator;

public class ArtifactDecorator : HeroDecorator
{
    public ArtifactDecorator(Hero hero) : base(hero) { }

    public override void Attack()
    {
        Console.WriteLine("Artifact activated.");
        base.Attack();
    }
}