namespace Builder;

public class HeroBuilder : CharacterBuilder
{
    public override Character Build()
    {
        return _character;
    }
}