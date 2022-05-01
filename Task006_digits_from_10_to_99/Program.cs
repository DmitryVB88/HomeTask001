//Дано число от 10 до 99. Указать, какая цифра числа больше.
Console.Write("Программа сгенерировала следующее число: ");
int a = new Random().Next(10, 99);
Console.WriteLine(a);
int x = (a / 10);
//Console.WriteLine(x);
int y = (a % 10);
//Console.WriteLine(y);
if( x > y)
{
    Console.Write("max = ");
    Console.WriteLine(x);
    Console.Write("min = ");
    Console.WriteLine(y);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(y);
    Console.Write("min = ");
    Console.WriteLine(x);
}
if (x == y)
{
    Console.Write("Числа равны между собой = ");
    Console.WriteLine(x);
    Console.WriteLine(y);
    }