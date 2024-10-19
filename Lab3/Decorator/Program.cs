namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        Hero warrior = new Warrior();
        Hero mage = new Mage();
        Hero paladin = new Paladin();

        // Equip warrior with armor and weapon
        warrior = new ArmorDecorator(warrior);
        warrior = new WeaponDecorator(warrior);
        warrior.Attack();

        // Equip mage with artifact
        mage = new ArtifactDecorator(mage);
        mage.Attack();

        // Equip paladin with armor, weapon, and artifact
        paladin = new ArmorDecorator(paladin);
        paladin = new WeaponDecorator(paladin);
        paladin = new ArtifactDecorator(paladin);
        paladin.Attack();
    }
}