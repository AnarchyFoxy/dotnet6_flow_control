using System;
using static System.Console;
using static System.Convert;

int a = 10;
double b = a;
WriteLine(b);
// Output:
// 10

double c = 9.8;
int d = (int) c;
WriteLine(d);
// Output:
// 9

long e = 10;
int f = (int)e;
WriteLine($"e ma wartość {e:N0}, a f ma wartość {f:N0}");

e = long.MaxValue;
f = (int)e;
WriteLine($"e ma wartość {e:N0}, a f ma wartość {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e ma wartość {e:N0}, a f ma wartość {f:N0}");
// Output:
/*
e ma wartość 10, a f ma wartość 10
e ma wartość 9,223,372,036,854,775,807, a f ma wartość -1
e ma wartość 5,000,000,000, a f ma wartość 705,032,704
 */

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g ma wartość {g}. a h ma wartość {h}");
// Output:
// g ma wartość 9.8. a h ma wartość 10

double[] liczby = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

foreach (double n in liczby)
{
    WriteLine($"ToInt({n}) ma wartość {ToInt32(n)}");
}
// Output:
/*
ToInt(9.49) ma wartość 9
ToInt(9.5) ma wartość 10
ToInt(9.51) ma wartość 10
ToInt(10.49) ma wartość 10
ToInt(10.5) ma wartość 10
ToInt(10.51) ma wartość 11
 */

foreach (double n in liczby)
{
    WriteLine(format:
        "Math.Round ({0}, 0, MidpointRounding.AwayFromZero) to {1}",
        arg0: n,
        arg1: Math.Round(value: n,
        digits: 0,
        mode: MidpointRounding.AwayFromZero));
}
// Output:
/*
Math.Round(9.49, 0, MidpointRounding.AwayFromZero) to 9
Math.Round(9.5, 0, MidpointRounding.AwayFromZero) to 10
Math.Round(9.51, 0, MidpointRounding.AwayFromZero) to 10
Math.Round(10.49, 0, MidpointRounding.AwayFromZero) to 10
Math.Round(10.5, 0, MidpointRounding.AwayFromZero) to 11
Math.Round(10.51, 0, MidpointRounding.AwayFromZero) to 11
*/

int liczba = 12;
WriteLine(liczba.ToString());

bool logiczna = true;
WriteLine(logiczna.ToString());

DateTime teraz = DateTime.Now;
WriteLine(teraz.ToString());

object ja = new object();
WriteLine(ja.ToString());
// Output:
/*
12
True
2/12/2023 6:57:20 PM
System.Object
*/

byte[] obiekt_binarny = new byte[128];
(new Random()).NextBytes(obiekt_binarny);
WriteLine("Binarny obiekt jako bajty:");

for (int indeks = 0; indeks < obiekt_binarny.Length; indeks++)
{
    Write($"{obiekt_binarny[indeks]:X} ");
}
WriteLine();

string zakodowane = Convert.ToBase64String(obiekt_binarny);
WriteLine($"Obiekt binarny jako Base64: {zakodowane}");
// Output:
/*
Binarny obiekt jako bajty:
EE C0 3A 89 3A FC 11 DA 0 2C 53 EC B3 9F E4 33 73 DA 2E F3 C 55 D0 F3 62 C5 C9 89 49 34 F9 A8 35 69 28 9E A3 4B D3 6D C2 67 44 A8 EC D9 61 C B 7C 1D 46 AF 97 76 6E 7D E6 3F 3E B2 70 24 CD 57 F9 DC BA 21 CC 19 59 9A 28 EA 71 DD 4A 3B 92 F9 7F DD F0 3B D4 9B 38 F0 1C 1D 65 B4 85 50 78 43 1F E0 7C B9 22 27 33 3D 1E A8 6D 91 B6 6C FE F2 13 1F 5E AF C2 82 29 73 FA D 45 31 F2 FE C9 
Obiekt binarny jako Base64: 7sA6iTr8EdoALFPss5/kM3PaLvMMVdDzYsXJiUk0+ag1aSieo0vTbcJnRKjs2WEMC3wdRq+Xdm595j8+snAkzVf53LohzBlZmijqcd1KO5L5f93wO9SbOPAcHWW0hVB4Qx/gfLkiJzM9HqhtkbZs/vITH16vwoIpc/oNRTHy/sk=
 */

int wiek = int.Parse("30");
//DateTime urodziny = DateTime.Parse("16/3/1992");

//WriteLine($"Mam {wiek} lat.");
//WriteLine($"Urodziny mam {urodziny}.");
//WriteLine($"Urodziny mam {urodziny:D}.");

// output:
/*
Mam 30 lat.
Urodziny mam 16/3/1992 12:00:00 AM.
Urodziny mam Monday, March 16, 1992.
 */

int ilosc;
Write("Ile mamy tutaj jajek?");
string dane = ReadLine();

if (int.TryParse(dane, out ilosc))
{
    WriteLine($"Mamy {ilosc} jajek.");
}
else
{
    WriteLine("Konwersja danych nie powiodła się.");
}
// Output:
/*
Ile mamy tutaj jajek? 67
Mamy 67 jajek.
*
Ile mamy tutaj jajek? trzysta
Konwersja danych nie powiodła się.
 */

//WriteLine("Przed parsowaniem");
//Write("Ile masz lat? ");
//string? lata = ReadLine();
//try
//{
//    int liczba_lat = int.Parse(lata);
//    WriteLine($"Masz już {liczba_lat} lat!");
//}
//catch
//{
//    WriteLine("No i coś się nie udało.");
//}
//WriteLine("Parsowanko zakończone.");
///* 
//Ile masz lat? 30
//Masz już 30 lat!
//Parsowanko zakoń czone.
//*
//Ile masz lat? trzydzieści
//No i coś się nie udał o.
//Parsowanko zakoń czone.
// */

WriteLine("Przed parsowaniem");
Write("Ile masz lat? ");
string? lata = ReadLine();
try
{
    int liczba_lat = int.Parse(lata);
    WriteLine($"Masz już {liczba_lat} lat!");
}
catch (OverflowException)
{
    WriteLine("Chyba jesteś wampirem");
}
catch (FormatException)
{
    WriteLine("Podany wiek nie jest liczbą");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} z komunikatem: {ex.Message}");
}
WriteLine("Parsowanko zakończone.");
// Output:
/*
Przed parsowaniem
Ile masz lat? 34556565677667
Chyba jesteś wampirem
Parsowanko zakończone.
 */

Write("Podaj kwotę: ");
string? kwota = ReadLine();
try
{
    decimal wartosc_kwoty = decimal.Parse(kwota);
}
catch (FormatException) when (kwota.Contains("$"))
{
    WriteLine("Kwota nie może zawierać znaku dolara!");
}
catch (FormatException)
{
    WriteLine("Kwota może składać się wyłącznie z cyfr");
}
// Output
/*
Podaj kwotę: $30
Kwota nie może zawierać znaku dolara!
 */