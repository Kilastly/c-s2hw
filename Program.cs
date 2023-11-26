// Задача 1 Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// Console.Clear();
// Console.WriteLine("Введите число ");
// int number = int.Parse(Console.ReadLine()!);
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"Число {number} кратно 7 и 23");
// }
//     else
//     {
//         Console.WriteLine($"Число {number}  не кратно 7 и 23");
//     }

// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.Clear();
Console.WriteLine("Введите координаты точки x");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки y");
int y = int.Parse(Console.ReadLine()!);
if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else if (x >0 && y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Точка на оси координат");
}


