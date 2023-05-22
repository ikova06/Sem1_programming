// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int Counting (int number)
// {
//     int count = 0;
//     while (number > 0)
//     {
//         number/=10;
//         count++;
//     }
//     if (count == 0)
//     {
//         count++;
//     }
//     return count;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = Counting(number);

// System.Console.WriteLine ($"Кол-во цифр в числе {number} = {count}");

//Второй вариант решения задачи

Console.Write("Введите число: ");
string num = Console.ReadLine();

if(int.TryParse(num, out int number))
{
   System.Console. WriteLine(num.Length); 
}
else
{
    System.Console. WriteLine("Введите число");
}


