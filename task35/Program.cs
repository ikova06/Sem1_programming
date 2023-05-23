﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 130);
}
return arr;
}


System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));

int newLength = array.Length/2 + array.Length%2;

int[] newArray = new int [newLength];

for (int i = 0; i < array.Length/2; i++)
{
newArray [i] = array [i] *= array[array.Length- i -1];
}
if (array.Length % 2 == 1)
{
newArray[newArray.Length - 1] = array[array.Length / 2];
}
System.Console.WriteLine(string.Join(", ", newArray));
