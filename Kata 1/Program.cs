Console.WriteLine("Welcome, brave adventurer! What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Greetings, {name}! Your journey begins now...\nOn a scale of 1 to 10, how excited are you to start this quest?");
int excited = int.Parse(Console.ReadLine());
if (excited >= 7)
{
    Console.WriteLine("Fantastic! You seem ready to take on any challenge!");
}
if (excited < 7)
{
    Console.WriteLine($"{name}! You can do it!");
}