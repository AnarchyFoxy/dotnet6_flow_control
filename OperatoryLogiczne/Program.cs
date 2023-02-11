using static System.Console;

bool a = true;
bool b = false;
WriteLine($"AND | a | b ");
WriteLine($"a | {a & a,-5} | {a & b,-5} ");
WriteLine($"b | {b & a,-5} | {b & b,-5} ");
WriteLine();
WriteLine($"OR | a | b ");
WriteLine($"a | {a | a,-5} | {a | b,-5} ");
WriteLine($"b | {b | a,-5} | {b | b,-5} ");
WriteLine();
WriteLine($"XOR | a | b ");
WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");
// Output:
/*
AND | a | b 
a | True  | False 
b | False | False 

OR | a | b 
a | True  | True  
b | True  | False 

XOR | a | b 
a | False | True  
b | True  | False 
 */

WriteLine();
WriteLine($"a & ZrobCos() = {a & ZrobCos()}");
WriteLine($"b & ZrobCos() = {b & ZrobCos()}");
WriteLine();
WriteLine($"a && ZrobCos() = {a && ZrobCos()}");
WriteLine($"b && ZrobCos() = {b && ZrobCos()}");

static bool ZrobCos()
{
    WriteLine("Wykonuję ciężką pracę.");
    return true;
}

// Output
/*
Wykonuję ciężką pracę.
a & ZrobCos() = True
Wykonuję ciężką pracę.
b & ZrobCos() = False

Wykonuję ciężką pracę.
a && ZrobCos() = True
b && ZrobCos() = False
 */