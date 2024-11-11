string name = "Santa";
int level = 4;
float healthPoints = 165f;
double experiencePoints = 2491.54d;
bool hasMagicAbility = true;
char rank = 'A';
double nextLevelThreshold = 500d * (level + 1);
double pointsToNextLevel = nextLevelThreshold - experiencePoints;
float pointsToNextLevelFloat = (float)pointsToNextLevel;

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Health Points: {healthPoints}");
Console.WriteLine($"Experience Points: {experiencePoints}");
Console.WriteLine($"Magic Ability: {hasMagicAbility}");
Console.WriteLine($"Rank: {rank}");
Console.WriteLine($"Points needed to reach next level: {pointsToNextLevelFloat}");