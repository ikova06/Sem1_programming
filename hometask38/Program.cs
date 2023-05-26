// Задача 38: Задайте массив вещественных(тип double) чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

Console.WriteLine("Введите размер массива ");
double n = Convert.ToDouble(Console.ReadLine());
double[] FillArrayWithRandomNumber(double n)
{
double[] array = new double[n];
Random rand = new Random();
for (double i = 0; i < array.Length; i++)
{
array[i] = rand.NextDouble();   
}
return array;
}


