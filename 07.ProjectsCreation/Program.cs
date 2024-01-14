internal class Program
{
    private static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());


        Console.WriteLine($"The architect {firstName} will nee {lastName} hours to complet {age} project/s.");
    }
}