var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = 1;

for (int i = a; i <= b; i++)
{
   c *= i;
}
Console.WriteLine(c);