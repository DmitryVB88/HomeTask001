//Выяснить, кратно ли число заданному, если нет, вывести остаток. 
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
int b = new Random().Next (1,10);
//Console.WriteLine(a);
Console.WriteLine(b);
if(b > a) //в случае, когда введенное число больше сгенерированного, они меняются местами.
{
 int n = a;
    a = b;
    b = n;

    Console.WriteLine(a);
    Console.WriteLine(b);
}
int mult = a % b;
    Console.WriteLine(mult);
if(mult == 0)
 {
     Console.WriteLine("Введенное число, кратно сгенерированному!");
    
 }
else
 {
     Console.WriteLine("Данной число не кратно сгенерированному, остаток от деления =");
     Console.WriteLine(mult);
 }