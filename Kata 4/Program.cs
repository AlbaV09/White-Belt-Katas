
int maxWave = 3;
int maxEnemy = 4;
for (int wave = 1; wave <= maxWave; wave++)
{
    Console.WriteLine($"Wave {wave} is starting!");
    for (int enemy = 1; enemy <= maxEnemy; enemy++)
    {
        Console.WriteLine($" Enemy #{enemy} has spawned.");
        Thread.Sleep(500);
    }
    Thread.Sleep(2000);
}
Console.WriteLine("All waves completed! Victory is yours!");