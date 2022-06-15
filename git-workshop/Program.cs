// See https://aka.ms/new-console-template for more information
using System.Globalization;
using git_workshop;
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

Console.WriteLine($"Geben Sie eine Ziffer für die gewünschte Operation ein");
Console.WriteLine($"1: Summe");
Console.WriteLine($"2: Differenz");
string? eingabeOperation = Console.ReadLine();
int operation = 0;
string operationName = "";
int result = -99;
try
{
    operation = int.Parse(eingabeOperation ?? "0");
    Operation operationValue = (Operation)operation;
    
    switch (operationValue)
    {
        case Operation.NICHT_GUELTIG:
            operationName = "Nicht gültig";
            break;
        case Operation.ADDITION:
            operationName = "Summe";
            result = zahl1 + zahl2;
            break;
        case Operation.SUBTRACTION:
            operationName = "Differenz";
            result = zahl2 - zahl1;
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }
    
    Console.WriteLine($"Ihre Eingabe war {operation}");
    Console.WriteLine($"Ihre Operation war {operationName}");
    Console.WriteLine($"Ihr Ergebnis ist {result}");
}
catch
{
    Console.Error.WriteLine("Bei der Umwandlung der Eingabe ist ein Fehler aufgetreten");
}

Console.WriteLine("ENDE");
Console.Read();