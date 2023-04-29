// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
if (day == 1 && day == 2 && day == 3 && day = 4 && day == 5)
{
Console.WriteLine("Это не выходной");
}
if (day == 2)
{
Console.WriteLine("Это не выходной");
}
if (day == 3)
{
Console.WriteLine("Это не выходной");
}
if (day == 4)
{
Console.WriteLine("Это не выходной");
}
if (day == 5)
{
Console.WriteLine("Это не выходной");
}
if (day == 6)
{
Console.WriteLine("Это выходной");
}
if (day == 7)
{
Console.WriteLine("Это выходной");
}
}
else
{
Console.WriteLine("Это не день недели");
}
