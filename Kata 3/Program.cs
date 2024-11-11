Random random = new Random();
int playerLuck = random.Next(1, 11);
Console.WriteLine("You find a mysterious treasure chest! What will you do?\n1. Open the chest\n2. Ignore the chest\n3. Leave the area");

PlayerChoice:
int playerChoice = int.Parse(Console.ReadLine());

if (playerChoice == 1)
{
    Console.WriteLine("You try to open the chest...");
    if (playerLuck > 7)
    {
       Console.WriteLine("Success! The chest contains a rare gem."); 
    } else if (playerLuck >= 5)
    {
        Console.WriteLine("Congratulations you have found some gold.");
    }
    else
    {
        Console.WriteLine("The chest was trapped.");
    }
} else if (playerChoice == 2)
{
    Console.WriteLine("You ignore the chest and continue on your journey.");
} else if (playerChoice == 3)
{
    Console.WriteLine("You leave the area and the mystery was left unsolved.");
}
else
{
    Console.WriteLine("Error! Please try again.");
    goto PlayerChoice;
}
/*
Requirements:
    Declare a playerLuck variable with a value between 1 and 10.
    Present the player with choices when they encounter a treasure chest:
        Choice 1: Open the chest.
            If playerLuck > 7, display a success message for finding a rare gem.
            If playerLuck >= 5, display a message for finding some gold.
            If playerLuck < 5, display a message saying the chest was trapped.
        Choice 2: Ignore the chest, displaying a message saying the player continued on their journey.
        Choice 3: Leave the area, displaying a message saying the mystery was left unsolved.
    Display an error message if the player enters an invalid choice.

Expected Outcome: The program should respond differently based on the player’s choice and playerLuck. Example output:

You find a mysterious treasure chest! What will you do?
1. Open the chest
2. Ignore the chest
3. Leave the area
> 1
You try to open the chest...
Success! The chest contains a rare gem.

C# Features:
    Nested Conditionals: Helps structure multi-level conditions. For example:

if (choice == "open")
{
    if (luck > 7) 
    { 
	    /* success outcome * / 
    }
    else if (luck >= 5) 
    { 
	    /* minor success outcome * / 
    }
    else 
    { 
	    /* failure outcome * / 
    }
}
*/