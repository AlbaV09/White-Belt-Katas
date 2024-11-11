using System.Globalization;
Random random = new Random();
int playerLuck = random.Next(1, 11);
Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
string playerAnswer = Console.ReadLine();
if (playerAnswer.ToLower() == "yes")
{
    Console.WriteLine("Attempting to attack...");
    if (playerLuck > 7)
    {
     Console.WriteLine("Success! Your attack hits the enemy.");   
    } else if (playerLuck < 6)
    {
        Console.WriteLine("The attack missed the enemy.");
    }
    else
    {
        Console.WriteLine("The attack barely succeeded.");
    }
} else if (playerAnswer.ToLower() == "no")
{
    Console.WriteLine("The player retreated");
}