//Дано число от 10 до 99. Указать, какая цифра числа больше.
int a = new Random().Next(10, 99);
Console.WriteLine(a);
int x = (a / 10);
Console.WriteLine(x);
int y = (a % 10);
Console.WriteLine(y);
if( x > y)
{
    Console.WriteLine("max= ");
    Console.WriteLine(x);
    Console.WriteLine("min=");
    Console.WriteLine(y);
}
else
{
    Console.WriteLine("max=");
    Console.WriteLine(y);
    Console.WriteLine("min=");
    Console.WriteLine(x);
}
if (x == y)
{
    Console.WriteLine("Числа равны между собой");
    Console.WriteLine(x);
    Console.WriteLine(y);
    }