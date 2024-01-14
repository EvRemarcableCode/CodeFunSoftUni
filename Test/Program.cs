double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ramMemory = int.Parse(Console.ReadLine());
double videoCardPrice = 250 * videoCards;
double processorPrice = (videoCardPrice * 0.35) * processors;
double ramMemoryPrice = (0.1 * videoCardPrice) * ramMemory;
double totalPrice = videoCardPrice + processorPrice + ramMemoryPrice;

if (videoCards > processors)
{
    totalPrice -= totalPrice * 0.15;
}
if (budget >= totalPrice)
{
    Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
}

else
{
    Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
}