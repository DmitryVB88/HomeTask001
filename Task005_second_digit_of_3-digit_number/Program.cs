//Найти вторую цифру трехзначного числа.
Console.WriteLine("Введите трёхзначное число:");
int a = int.Parse(Console.ReadLine());
if (a > 99 && a < 1000);
{
    Console.WriteLine("Вторая цифра трёхзначного числа =");
    Console.WriteLine(a / 10 % 10);
    
}

//else

//      Console.WriteLine("Данное число, не трёхзначное.");
//}