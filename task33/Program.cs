// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));

System.Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
{
    Console.WriteLine ("Ваше число есть в массиве");
    break;
}
else 
{
    Console.WriteLine ("Вашего числа в массиве нет");
    break;
}
}

