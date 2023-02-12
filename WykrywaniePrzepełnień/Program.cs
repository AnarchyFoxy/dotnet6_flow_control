using static System.Console;

int x = int.MaxValue - 1;
WriteLine($"Wartość początkowa: {x}");
x++;
WriteLine($"Po inkrementacji: {x}");
x++;
WriteLine($"Po inkrementacji: {x}");
x++;
WriteLine($"Po inkrementacji: {x}");
// Output:
/*
Wartość początkowa: 2147483646
Po inkrementacji: 2147483647
Po inkrementacji: -2147483648
Po inkrementacji: -2147483647
*/

//checked
//{
//    int y = int.MaxValue - 1;
//    WriteLine($"Wartość początkowa: {y}");
//    y++;
//    WriteLine($"Po inkrementacji: {y}");
//    y++;
//    WriteLine($"Po inkrementacji: {y}");
//    y++;
//    WriteLine($"Po inkrementacji: {y}");
//}
// Output:
/*
Wartość początkowa: 2147483646
Po inkrementacji: 2147483647
Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
 */

try
{
    checked
    {
        int y = int.MaxValue - 1;
        WriteLine($"Wartość początkowa: {y}");
        y++;
        WriteLine($"Po inkrementacji: {y}");
        y++;
        WriteLine($"Po inkrementacji: {y}");
        y++;
        WriteLine($"Po inkrementacji: {y}");
    }
}
catch (OverflowException)
{
    WriteLine("No i się przepełniło, ale złapałam");
}
// Output:
/*
Wartość początkowa: 2147483646
Po inkrementacji: 2147483647
No i się przepełniło, ale złapałam
 */

unchecked
{
    int y = int.MaxValue - 1;
    WriteLine($"Wartość początkowa: {y}");
    y++;
    WriteLine($"Po inkrementacji: {y}");
    y++;
    WriteLine($"Po inkrementacji: {y}");
    y++;
    WriteLine($"Po inkrementacji: {y}");
}
// Output
/*
Wartość początkowa: 2147483646
Po inkrementacji: 2147483647
Po inkrementacji: -2147483648
Po inkrementacji: -2147483647
 */