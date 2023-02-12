using static System.Console;
using System.IO;

string haslo = "ninja";

if (haslo.Length < 8)
{
    WriteLine("Twoje hasło jest za krótkie. Musi mieć przynajmniej 8 znaków.");
}
else
{
    WriteLine("Masz silne hasło.");
}

// Output:
// Twoje hasło jest za krótkie. Musi mieć przynajmniej 8 znaków.

object o = "3";
int j = 4;
if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o nie ma typu int, zatem nie mogę wykonać mnożenia :c");
}
// Output:
// o nie ma typu int, zatem nie mogę wykonać mnożenia :c

var liczba = (new Random()).Next(1, 7);
WriteLine($"Wylosowano liczbę {liczba}");

switch (liczba)
{
    case 1:
        WriteLine("Jeden");
        break;
    case 2:
        WriteLine("Dwa");
        break;
    case 3:
    case 4:
        WriteLine("Trzy lub cztery");
        goto case 1;
    case 5:
        goto Etykieta;
    default:
        WriteLine("Domyślnie");
        break;
}
WriteLine("Za instrukcją switch");
Etykieta:
WriteLine("Już za etykietą");
// Output:
// Wylosowano liczbę 5
// Już za etykietą

string sciezka = "/Users/refrasta/IDE/C#/Nauka/Price/dotnet6_flow_control/Rozdzial03";

Write("Wybierz: 0 dla odczytu albo Z dla zapisu: ");
ConsoleKeyInfo klawisz = ReadKey();
WriteLine();

Stream? s;

if (klawisz.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(sciezka, "plik.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);
}
else
{
    s = File.Open(
        Path.Combine(sciezka, "plik.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);
}

string komunikat;

switch (s)
{
    case FileStream plik_do_zapisu when s.CanWrite:
        komunikat = "Strumień prowadzi do pliku, do którego mogę pisać.";
        break;
    case FileStream plik_tylko_do_odczytu:
        komunikat = "Strumień prowadzi do pliku tylko do odczytu.";
        break;
    case MemoryStream ms:
        komunikat = "Strumień prowadzi do adresu w pamięci.";
        break;
    default:
        komunikat = "To strumień innego typu";
        break;
    case null:
        komunikat = "Strumień ma wartość null";
        break;
}
WriteLine(komunikat);
// Output:
/*
Wybierz: 0 dla odczytu albo Z dla zapisu: O
Strumień  prowadzi do pliku, do któ rego mogę pisać.
 */

komunikat = s switch
{
    FileStream plik_do_zapisu when s.CanWrite
    => " Strumień prowadzi do pliku, do którego mogę pisać.",
    FileStream plik_tylko_do_odczytu
    => " Strumień prowadzi do pliku tylko do odczytu.",
    MemoryStream ms
    => "Strumień prowadzi do adresu w pamięci.",
    null
    => " Strumień ma wartość null.",
    _
    => "To strumień innego typu"
};

WriteLine(komunikat);
// Output:
/*
Wybierz: 0 dla odczytu albo Z dla zapisu: O
Strumień  prowadzi do pliku, do któ rego mogę pisać.
 */