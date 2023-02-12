using static System.Console;

int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

// Output:
/*
0
1
2
3
4
5
6
7
8
9
 */

string? haslo;
int count = 0;
do
{
    Write("Podaj swoje haslo: ");
    haslo = ReadLine();
    if (count == 10)
    {
        WriteLine("Koniec prób");
        break;
        
    }
    count++;

} while (haslo != "sekret");

WriteLine("Tak jest!");
/*
Podaj swoje haslo: 0
Podaj swoje haslo: 1
Podaj swoje haslo: 2
Podaj swoje haslo: 3
Podaj swoje haslo: 4
Podaj swoje haslo: 5
Podaj swoje haslo: 6
Podaj swoje haslo: 7
Podaj swoje haslo: 8
Podaj swoje haslo: 9
Podaj swoje haslo: 0
Koniec prób
Tak jest!
 */

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}
// Output:
/*
1
2
3
4
5
6
7
8
9
10
 */

string[] names = { "Astryda", "Gazela", "Kicia" };
foreach (string name in names)
{
    WriteLine($"{name} ma {name.Length} znaków");
}
// Output:
/*
Astryda ma 7 znakó w
Gazela ma 6 znakó w
Kicia ma 5 znakó w
 */

