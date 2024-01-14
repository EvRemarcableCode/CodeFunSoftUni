double seconds = double.Parse (Console.ReadLine ());
double meters = double.Parse (Console.ReadLine ());
double time = double.Parse (Console.ReadLine ());
double totalTime = meters * time;
double late= Math.Floor(meters / 15) * 12.5;
double totalIvan = late + totalTime;
double timeIvan = totalIvan - seconds;

if (totalIvan >= seconds)
{
    Console.WriteLine($"No, he failed! He was {timeIvan:F2} seconds slower.");
}
else
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalIvan:F2} seconds.");
}