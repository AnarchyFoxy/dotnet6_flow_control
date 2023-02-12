using static System.Console;

// ok, now the excercise is to provide two numbers and make division and catch all exceptions

string input1;
string input2;

try
{
    Write("Podaj liczbę od zera do 255: ");
    input1 = ReadLine();
    Write("Podaj inną liczbę od 0 do 255: ");
    input2 = ReadLine();
    byte x = byte.Parse(input1);
    byte y = byte.Parse(input2);
    WriteLine($"{x} podzielone przez {y} to: {x / y}");
}
catch (FormatException)
{
    WriteLine($"Problem. Nie podano cyfry ani liczby");
}
catch (OverflowException)
{
    WriteLine($"Problem. Przepełnienie stosu");
}
catch (Exception e)
{
    WriteLine($"Problem {e}");
}

// Output:
/*
Podaj liczbę od zera do 255: 256
Podaj inną liczbę od 0 do 255: 290
Problem. Przepeł nienie stosu
 */
/*
Podaj liczbę od zera do 255: 200
Podaj inną liczbę od 0 do 255: 13
200 podzielone przez 13 to: 1
 */
/*
Podaj liczbę od zera do 255: gazele
Podaj inną liczbę od 0 do 255: astrydy
Problem. Nie podano cyfry ani liczby
 */