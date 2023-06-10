﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размер 1й матрицы: ");
int[,] A = new int [Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < A.GetLength(0); i ++)
{
 for (int j = 0; j < A.GetLength(1); j ++)
 {
    Console.Write("A [{0},{1}] = ", i, j);
    A[i,j] =  Convert.ToInt32(Console.ReadLine());
 }
}

Console.WriteLine("Введите размер 2й матрицы: ");
int[,] B = new int [Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < A.GetLength(0); i ++)
{
 for (int j = 0; j < A.GetLength(1); j ++)
 {
    Console.Write("B [{0},{1}] = ", i, j);
    B[i,j] =  Convert.ToInt32(Console.ReadLine());
 }
}

Console.WriteLine("Матрица А: ");
Print(A);
Console.WriteLine("Матрица B: ");
Print(B);
Console.WriteLine("Матрица C = A*B: ");
int [,] C = Multiplication(A,B);
Print(C);

int[,] Multiplication(int[,]a, int [,]b)
{
    if (a.GetLength(1) != b.GetLength(0))
    Console.WriteLine("Такие матрицы нельзя пермножать: ");
    int [,] c = new int [a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i ++)
    {
        for (int j = 0; j < b.GetLength(1); j ++)
        {
            for (int k = 0; k < b.GetLength(0); k ++)
            {
                c[i,j] += a[i,k] * b[k,j];
            }
        }
    }
    return c;
}

void Print(int[,]a)
{
    for (int i=0; i <a.GetLength(0); i++)
    {
     for (int j=0; j <a.GetLength(1); j++)  
     {
        Console.Write("{0} ", a[i,j]);
     } 
     Console.WriteLine(0);
    }
}