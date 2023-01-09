/*
int a = 5;
int b = 12;

int c = a + b;
c *= 5;

Console.WriteLine(c);
*/

// Casting
int a = Convert.ToInt32("5"); // Funciona com o null
int b = int.Parse("7");
Console.WriteLine(a);

// Conversão correta
string c = "15-";
int d = 0;
int.TryParse(c, out d);