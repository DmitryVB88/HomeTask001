//Удалить вторую цифру трехзначного числа. 
Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());
if (a > 99 && a < 999)
{
    int secdig = (a / 10 % 10);
    int result = (secdig * 10);
    int result2 = a - result;
    Console.Write("Сейчас удалим вторую цифру введённого числа, и вот что получится = ");
    Console.WriteLine(result2);
    
}
else
{
    Console.WriteLine("Введенное число не является трёхзначным!");
}