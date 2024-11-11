Hero hero = new Hero();
hero.health = 70f;
hero.attackPower = 10f;
hero.healing = 5f;

Enemy enemy = new Enemy();
enemy.health = 80f;
enemy.attackPower = 10f;

Console.WriteLine($"Hero's Health: {hero.health}\nGoblin's Health: {enemy.health}\nChoose an action:\n1. Attack\n2. Heal");

while (hero.health > 0 && enemy.health > 0)
{
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine($"Hero attacks the Goblin!\nGoblin takes {hero.attackPower} damage.");
        enemy.health = enemy.health - hero.attackPower;
        if (enemy.health <= 0) break;
        Thread.Sleep(1000);
        Console.WriteLine($"Goblin attacks Hero!\nHero takes {enemy.attackPower} damage.");
        hero.health -= enemy.attackPower;
        if (hero.health <= 0) break;
    }
    else if (choice == 2)
    {
        hero.health += hero.healing;
        Console.WriteLine($"The Hero heals {hero.healing}.");
        Thread.Sleep(1000);
        Console.WriteLine($"Goblin attacks Hero!\nHero takes {enemy.attackPower} damage.");
        hero.health -= enemy.attackPower;
        if (hero.health <= 0) break;
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }
}

if (hero.health <= 0)
{
   Console.WriteLine("Game over, the Hero is dead."); 
} else if (enemy.health <= 0)
{
    Console.WriteLine("Congratulations! Hero has defeated the Goblin!");
}

public class Identity
{
    public float health;
    public float attackPower;
}

public class Hero : Identity
{
    public float healing = 5f;
}

public class Enemy : Identity
{
    
}