Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
int div = (a % 2);

if(div == 0)
{
    Console.WriteLine("Это число чётное!");
}

else
{
    Console.WriteLine("Это число нечётное! В следующий раз, хорошенько подумай, прежде чем что-то на клавиатуре набирать.");
}
