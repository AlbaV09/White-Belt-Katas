string name = "Rufus";
int healthPoints = 100;
float attackPower = 1.5f;
float experiencePoints = 352.89f;
bool isParalyzed = true;
string currencyAmount = "150,3333333";

double healthPointsDouble = healthPoints;
int attackPowerInt = (int) attackPower;
int experiencePointsInt = Convert.ToInt32(experiencePoints);
double currencyAmountDouble = double.Parse(currencyAmount);
int.TryParse(name, out int result);

Console.WriteLine($"Health as double (implicit conversion): {healthPointsDouble}");
Console.WriteLine($"Attack Power as int (explicit conversion); {attackPowerInt}");
Console.WriteLine($"Experience as int (using Convert): {experiencePointsInt}");
Console.WriteLine($"Gold Coins (parsed from string): {currencyAmountDouble}");
if (result == 0)
{
    Console.WriteLine($"Parsing failed: 'invalid' is not a number."); 
}