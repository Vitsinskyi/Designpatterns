namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HeroBuilder heroBuilder = new HeroBuilder();
            Character hero = heroBuilder.SetName("Hero")
                .SetHairColor("Black")
                .SetEyeColor("Blue")
                .SetClothes("Armor")
                .SetInventory("Sword")
                .Build();

            Console.WriteLine($"Created a hero named {hero.Name} with hair color {hero.HairColor}, eye color {hero.EyeColor}, wearing {hero.Clothes}, and carrying {hero.Inventory}.");

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            Character enemy = enemyBuilder.SetName("Enemy")
                .SetHairColor("Red")
                .SetEyeColor("Green")
                .SetClothes("Robe")
                .SetInventory("Some staff")
                .Build();

            Console.WriteLine($"Created an enemy named {enemy.Name} with hair color {enemy.HairColor}, eye color {enemy.EyeColor}, wearing {enemy.Clothes}, and carrying {enemy.Inventory}.");
        }
    }
}
