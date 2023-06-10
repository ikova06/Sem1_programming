// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

System.Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array3d = new int[x,y,z];

void WriteArray (int[,,] array3d)
{
  for (int i = 0; i < array3d.GetLength(0); i++)
  {
    for (int j = 0; j < array3d.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3d.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3d[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3d)
{
  int[] temp = new int[array3d.GetLength(0) * array3d.GetLength(1) * array3d.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3d.GetLength(0); x++)
  {
    for (int y = 0; y < array3d.GetLength(1); y++)
    {
      for (int z = 0; z < array3d.GetLength(2); z++)
      {
        array3d[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

CreateArray(array3d);
WriteArray(array3d);