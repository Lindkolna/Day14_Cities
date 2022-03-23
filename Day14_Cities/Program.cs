// See https://aka.ms/new-console-template for more information
string[] cities = { "Copenhagen", "Paris", "Tokyo", "Bristol", "Mumbai", "Delhi", "Riga", "Vienna", "Warsaw", "Hamburg", "Cesis" };
Console.WriteLine("Please enter the last letter of the name of the city");
var lastLetter = Console.ReadLine();
for (int i = 0; i < cities.Length; i++)
{
    if (cities[i][cities[i].Length - 1] == lastLetter [0])
    {
        Console.WriteLine(cities[i]);
    }
}
Console.WriteLine("Please enter the first letter of the name of the city");
var firstLetter = Console.ReadLine();
for (int i = 0; i < cities.Length; i++)
{
    if (cities[i] [0] == firstLetter [0])
    {
        Console.WriteLine(cities[i]);
    }
}
Console.WriteLine("Please write the length of the city name:");
int.TryParse(Console.ReadLine(), out int cityLength);
for (int i = 0; i < cities.Length; i++)
{
    if (cities [i].Length == cityLength)
    {
        Console.WriteLine(cities[i]);
    }
}

