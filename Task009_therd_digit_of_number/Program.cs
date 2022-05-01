//Определить третью цифру числа. В случае отсутствия, сообщить, что ее нет. 
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if(a < 100 && a > -100)
{
    Console.WriteLine("В данном числе отсутствует третья цифра!");
}
if(a > 99 && a < 1000)
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(a % 10);  
}
if (a > 999 && a < 10000)
  {
      Console.Write("Третья цифра числа = ");
      Console.WriteLine(a / 10 % 10);
  }

if (a > 9999 && a < 100000)
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(a / 100 % 10);
}
if (a > 99999  && a < 1000000)
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(a / 1000 % 10);
}
if (a > 999999 && a < 10000000)
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(a / 10000 % 10);
}
if (a > 9999999)
{
    Console.WriteLine("Ну, достаточно! Поиграли и хватит!");

}
if(a < -99 && a > -1000)
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(a % 10);  
}
if (a < -999 && a > -10000)
  {
      Console.Write("Третья цифра числа = ");
      Console.WriteLine(a / 10 % 10);
  }

if (a < -9999 && a > -100000)
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(a / 100 % 10);
}
if (a < -99999  && a > -1000000)
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(a / 1000 % 10);
}
if (a < -999999 && a > -10000000)
{
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(a / 10000 % 10);
}
if (a < -9999999)
{
    Console.WriteLine("Давайте на этом закончим, хорошо?");

}