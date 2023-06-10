// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void FillMatrixWhithRandomNumbers(int[,] matrix)
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 11);
}
}
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} " + "\t");
}
System.Console.WriteLine();
}
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
Console.WriteLine();
PrintMatrix(matrix);

int SumLine(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

int minSum = 1;
int sum = SumLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
if (sum > SumLine(matrix, i))
{
sum = SumLine(matrix, i);
minSum = i+1;
}
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum} ");










// int MinLine(int[,] array);
// for (int j = 1; j < array.GetLength(1); j++)
// {
//     for (int i = 1; i < array.GetLength(0); i++)
//     int Line(int[] array)

// Random rnd = new Random();
// int number = Convert.ToInt32(Console.ReadLine());
// double[] Array = new double[number];

// for (int i = 0; i < number; i ++)
// {
//     Array [i] = rnd.NextDouble () + rnd.Next (1, 21);
//     Console.Write($" {Array [i]} ");
// }
// double min = Array [0];
// double max = Array [0];
// for (int i = 0; i < number; i++)
// {
// if (Array [i]> max)
// {
//     max = Array [i];
// }
// if (Array [i]> min)
// {
//     min = Array [i];
// }
// }




