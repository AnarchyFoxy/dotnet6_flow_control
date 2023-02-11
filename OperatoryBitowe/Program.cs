using static System.Console;

int a = 10;
int b = 6;

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}");
WriteLine($"a | b = {a | b}");
WriteLine($"a ^ b = {a ^ b}");
// Output:
/*
a = 10
b = 6
a & b = 2
a | b = 14
a ^ b = 12
 */

WriteLine($"a << 3 = {a << 3}");
WriteLine($"a * 8 = {a * 8}");
WriteLine($"b >> 1 = {b >> 1}");
/*
a << 3 = 80
a * 8 = 80
b >> 1 = 3
 */

WriteLine();
WriteLine("Wypisuję liczby całkowite w formie binarnej:");
WriteLine($"a     = {Na_binarny_ciag_znakow(a)}");
WriteLine($"b     = {Na_binarny_ciag_znakow(b)}");
WriteLine($"a & b = {Na_binarny_ciag_znakow(a & b)}");
WriteLine($"a | b = {Na_binarny_ciag_znakow(a | b)}");
WriteLine($"a ^ b + {Na_binarny_ciag_znakow(a ^ b)}");

static string Na_binarny_ciag_znakow(int liczba)
{
    return Convert.ToString(liczba, toBase: 2).PadLeft(8, '0');
}

// Output:
/*
Wypisuję liczby cał kowite w formie binarnej:
a     = 00001010
b     = 00000110
a & b = 00000010
a | b = 00001110
a ^ b + 00001100
 */

