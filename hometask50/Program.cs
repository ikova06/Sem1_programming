// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 11);
Console.Write($"{matrix[i, j]} " + "\t");
}
Console.WriteLine();
}
}


// void PrintMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// System.Console.Write($"{matrix[i, j]} " + "\t");
// }
// System.Console.WriteLine();
// }
// }

void FindArrayElement(int [,] element, int userindex)
{
    bool find = false;
    for (int i = 0; i < element.GetLength(0); i++)
{   
for (int j = 0; j < element.GetLength(1); j++)
{
if (element [i, j] == userindex)
Console.WriteLine("Индекс заданного числа "+ i + " " +j);
find = true;
}
}
if (!find)
Console.WriteLine("Такого числа нет в массиве");
}

System.Console.Write("Введите строку массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите столбец массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
FillMatrixWhithRandomNumbers(matrix);
// PrintMatrix(matrix);
FindArrayElement(matrix, a);
