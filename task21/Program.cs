﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int square = 1;
// while (square <= num)
// {
// System.Console.WriteLine(Math.Pow(square, 2));
// square++;
// }
for (int i = 1; i <= num; i++)
{
System.Console.Write(Math.Pow(i, 2) + " ");
}