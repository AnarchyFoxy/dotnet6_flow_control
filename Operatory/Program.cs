using static System.Console;

int a = 3;
int b = a++;
WriteLine($"a ma wartość {a}, b ma wartość {b}");
// Output:
// a ma wartość 4, b ma wartość 3

int c = 3;
int d = ++c;
WriteLine($"c ma wartość {c}, d ma wartość {d}.");
// Output:
// c ma wartość 4, d ma wartość 4.

int e = 11;
int f = 3;

WriteLine($"e ma wartość {e}, f ma wartość {f}");
WriteLine($"e + d = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
// Output:
/*
e ma wartość 11, f ma wartość 3
e + d = 14
e - f = 8
e * f = 33
e / f = 3
e % f = 2
 */

double g = 11.0;
WriteLine($"g ma wartość {g:N1}, f ma wartośc {f}");
WriteLine($"g / f = {g / f}");
// Output:
/*
g ma wartość 11.0, f ma wartośc 3
g / f = 3.6666666666666665
 */

