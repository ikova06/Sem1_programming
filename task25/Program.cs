// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power (int numberA, int numberB)

{
    int number = numberA;
    for(int i =1; i < numberB; i++)
    {
      number=number * numberA;
    }
    
    return number;
}
// System.Console.Write(int.numberA);

System.Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int num = Power(numA, numB);

System.Console.WriteLine($"Число A в натуральной степени B {num}");