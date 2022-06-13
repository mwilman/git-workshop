// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.WriteLine("Hello, World!");

Console.WriteLine("Bitte geben Sie eine Zahl ein");
string? eingabe1 = Console.ReadLine();

Console.WriteLine("Bitte geben Sie eine zweite Zahl ein");
string? eingabe2 = Console.ReadLine();
int zahl1 = 0, zahl2 = 0;
try
{
    zahl1 = int.Parse(eingabe1 ?? "0");
    zahl2 = int.Parse(eingabe2 ?? "0");
}
catch
{
    Console.Error.WriteLine("Bei der Umwandlung der Eingabe ist ein Fehler aufgetreten");
}

Console.WriteLine($"Die erste Zahl ist {zahl1}");
Console.WriteLine($"Die zweite Zahl ist {zahl2}");