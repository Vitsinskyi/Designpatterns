namespace Builder;

public abstract class CharacterBuilder
{
    protected Character _character = new Character();

    public CharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public CharacterBuilder SetHairColor(string color)
    {
        _character.HairColor = color;
        return this;
    }

    public CharacterBuilder SetEyeColor(string color)
    {
        _character.EyeColor = color;
        return this;
    }

    public CharacterBuilder SetClothes(string clothes)
    {
        _character.Clothes = clothes;
        return this;
    }

    public CharacterBuilder SetInventory(string inventory)
    {
        _character.Inventory = inventory;
        return this;
    }

    public abstract Character Build();
}