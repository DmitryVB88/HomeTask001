Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
//Console.WriteLine(a);
//Console.WriteLine(b);
int x = a * a;
Console.WriteLine(x);

if(x / b == b)
  {
       Console.WriteLine("Квадрат числа A равен квадрату числа B.");
       Console.WriteLine(b);
   }

else
{
   Console.WriteLine("Тождество не верно...");
}  
