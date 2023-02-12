using static System.Console;

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