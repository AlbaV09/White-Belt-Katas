for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Enemy #{i + 1} spawned!");
}

int condition = 0;
while (condition < 3)
{
    Console.WriteLine($"Enemy #{condition + 1} spawned!");
    condition++;
}