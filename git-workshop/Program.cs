// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.WriteLine("Hallo, Welt!");
Console.WriteLine("Guten Tag lieber Nutzer, World!");

Console.WriteLine("Bitte geben Sie eine Zahl ein");
string? ersteEingabe = Console.ReadLine();

Console.WriteLine("Bitte geben Sie eine zweite Zahl ein");
string? zweiteEingabe = Console.ReadLine();
int ersteZahl = 0, zweiteZahl = 0;
try
{
    ersteZahl = int.Parse(ersteEingabe ?? "0");
    zweiteZahl = int.Parse(zweiteEingabe ?? "0");
}
catch
{
    Console.Error.WriteLine("Bei der Umwandlung der Eingabe ist ein Fehler aufgetreten");
}

Console.WriteLine($"Die erste Zahl ist {ersteZahl}");
Console.WriteLine($"Die zweite Zahl ist {zweiteZahl}");