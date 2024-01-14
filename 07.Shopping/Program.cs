double userBudget = double.Parse(Console.ReadLine());
int videoCard = int.Parse(Console.ReadLine());
int procesor = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());
var discount = 0.15;
double videoCardPrice = 250 * videoCard;
double cpuPrice = videoCardPrice * 0.35 * procesor;
double ramPrice = videoCardPrice * 0.10 * ram;
double totalPrice = videoCardPrice + cpuPrice + ramPrice;

if (videoCard > procesor)
{
    totalPrice -= totalPrice * discount;
}

if (userBudget >= totalPrice)
{
    Console.WriteLine($"You have {userBudget - totalPrice:F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {totalPrice - userBudget:F2} leva more!");
}
