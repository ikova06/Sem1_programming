// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

int temp = 0;
int num1 = 0;
int num2 = 1;
System.Console.Write("0 1 ");
for (int i = 2; i< n; i++ )
{
temp = num1 + num2;
System.Console.Write($"{temp} ");
num1 = num2;
num2 = temp;
}