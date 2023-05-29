// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите сторону A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA + numberB > numberC &&  numberC + numberB > numberA && numberC + numberA > numberB)
{
    Console.WriteLine($"Треугольник такой длинны может существовать");
}
else 
{
    Console.WriteLine($"Треугольник такой длинны не может существовать");
}
