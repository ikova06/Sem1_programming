// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumOfElements(int m, int n)
{
if (m==n)
{
    return n;
}
else return m + SumOfElements(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равна {SumOfElements(m,n)}");



