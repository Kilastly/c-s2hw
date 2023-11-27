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

/* Задача 3: Напишите программу, которая принимает
на вход целое число из отрезка [10, 99] и показывает
наибольшую цифру числа.*/

// Console.Clear();
// Console.WriteLine("Введите число из отрезка [10, 99]: ");
// int number = int.Parse(Console.ReadLine()!);
//     while (number < 10 || number > 99)
//     {
//       Console.WriteLine("Вы ошиблись, \nВведите число из отрезка [10, 99]: ");
//        number = int.Parse(Console.ReadLine()!);  
//     }
// int firstDigit = number/10;
// int secondDigit = number % 10;  
//     if (firstDigit > secondDigit)
//     Console.WriteLine(firstDigit);
//     else
//     Console.WriteLine(secondDigit);

/*Задача 4: Напишите программу, которая на вход
принимает натуральное число N, а на выходе
показывает его цифры через запятую.
*/

Console.Clear();
Console.WriteLine("Введите число натуральное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 10)
{
    Console.WriteLine(number);
}
else
{
while(number >  10)
{
    int digit = number % 10; //9/7
    number /= 10; //87//8
    if(number > 0) //87/8
    {
        Console.Write(digit + ",");
    }
    else
    {
        Console.WriteLine(digit);
    }
}
Console.WriteLine(number);
}