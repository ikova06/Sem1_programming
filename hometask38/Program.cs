﻿// Задача 38: Задайте массив вещественных(тип double) чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1
Random rnd = new Random();
int number = Convert.ToInt32(Console.ReadLine());
double[] Array = new double[number];

for (int i = 0; i < number; i ++)
{
    Array [i] = rnd.NextDouble () + rnd.Next (1, 21);
    Console.Write($" {Array [i]} ");
}
double min = Array [0];
double max = Array [0];
for (int i = 0; i < number; i++)
{
if (Array [i]> max)
{
    max = Array [i];
}
if (Array [i]> min)
{
    min = Array [i];
}
}
Console.WriteLine($"Максимальный элемент: {max} Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");




