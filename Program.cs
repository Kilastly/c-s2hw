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

using System.Globalization;

Console.Clear();
Console.WriteLine("Введите число: ");
int PlaseNumber(int count, int number, int n)
{while(n > 0)
{
 n = number/count;
 count = 10*count;
}
return count;
}
int number = int.Parse(Console.ReadLine()!);
int count = 1;
int n =1;
int r = PlaseNumber(count,number,n);
Console.WriteLine(r);
// int digit;

// if (number / count <= 0)
// {
// Console.WriteLine(number);
// }
// else
// while(r > 0)
// {
//  r = number/count;
//  digit = number % count;
//  Console.WriteLine($"digit = {digit}");
//  count = 10/count;
// }
