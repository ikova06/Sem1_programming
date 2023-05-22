// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum (int number)
{
    int count = 0;
    while (number > 0)
    {
       count += number%10;
       number/=10;
    }
    if (count == 0)
    {
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = DigitSum(number);

System.Console.WriteLine ($"Кол-во цифр в числе {number} = {count}");