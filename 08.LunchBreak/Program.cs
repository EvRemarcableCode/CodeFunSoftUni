string serial = Console.ReadLine();
int timeEpisode = int.Parse(Console.ReadLine());
int timeBrake = int.Parse(Console.ReadLine());
double timeForLunch = timeBrake / 8.0;
double timeForBrake = timeBrake / 4.0;


double neededTime = timeEpisode + timeForLunch + timeForBrake;
double diffTime = Math.Abs(neededTime - timeBrake);

if (neededTime <= timeBrake)
{
    Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(diffTime)} minutes free time.");
}

else
{
    Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(diffTime)} more minutes.");
}