//Напечатать все чётные числа от 1 до N.
int min = 1;
int max = new Random().Next(2,100);
Console.WriteLine(min);
Console.WriteLine(max);

while(min <= max)
{
     if(min % 2 == 0)
     Console.Write(" " + min);
     min++;

}
