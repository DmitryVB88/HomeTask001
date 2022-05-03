 //Дано число от 10 до 99. Указать, какая цифра числа больше.
Console.Write("Программа сгенерировала число: ");
int number = new Random().Next(10, 99);
Console.WriteLine(number); 
int x = (number / 10);
//Console.WriteLine(x);
int y = (number % 10);
//Console.WriteLine(y);
if( x > y)
 {
     Console.Write("max = ");
     Console.WriteLine(x);
     Console.Write("min = ");
     Console.WriteLine(y);
 }
 if( y > x)
 {
     Console.Write("max = ");
     Console.WriteLine(y);
     Console.Write("min = ");
     Console.WriteLine(x);
 }
 if (x == y)
 {
     Console.Write("Первая цифра: ");
     Console.WriteLine(x);
     Console.Write("Вторая цифра: ");
     Console.WriteLine(y);
     Console.Write($"В числе {number} обе цифры равны между собой! ");
    
 }


//СТОУН!!!
// Console.WriteLine("Задание. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.");
// Console.Write("Введите двухзначное число: ");
// int Number2 = int.Parse(Console.ReadLine() ?? "0");
// if (10 <= Number2 && Number2 <= 99)
//     {
//         int Digit1 = Number2%10;
//         int Digit2 = Number2/10;
//         if (Digit1 > Digit2)
//             {
//                 Console.WriteLine($"В числе {Number2} наибольшая цифра {Digit1}.");
//             }
//         if (Digit2 > Digit1)
//             {
//                 Console.WriteLine($"В числе {Number2} наибольшая цифра {Digit2}.");
//             }
//         if (Digit2 == Digit1)
//             {
//                 Console.WriteLine($"Поздравляем! У вас близнецы! Обе цифры {Digit1}.");
//             }
        
//     }
// else
//     {
//         Console.WriteLine($"А какая разница какая из цифр больше, если у Вас с двузначными числами проблема?");
//     }
