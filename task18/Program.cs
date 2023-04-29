// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.WriteLine("Введите номер четверти");
// int quater = Convert.ToInt32(Console.ReadLine());

// if (quater == 1)
// {
// Console.WriteLine("x > 0 y > 0");
// }
// if (quater == 2)
// {
// Console.WriteLine("x < 0 y > 0");
// }
// if (quater == 3)
// {
// Console.WriteLine("x < 0 y < 0");
// }
// if (quater == 4)
// {
// Console.WriteLine("x > 0 y < 0");
// }



string[] quaters = {
"x > 0 y > 0",
"x < 0 y > 0",
"x < 0 y < 0",
"x > 0 y < 0"
};
Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater >= 1 && quater <= 4)
{
Console.WriteLine(quaters[quater - 1]);
}
else
{
System.Console.WriteLine("Неправльный номер четверти");
}



string FindDiapason(string[] quaters, int quater)
{
string result = quaters[quater - 1];
return result;
}

string[] quaters = {
"x > 0 y > 0",
"x < 0 y > 0",
"x < 0 y < 0",
"x > 0 y < 0"
};
Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater >= 1 && quater <= 4)
{
Console.WriteLine(FindDiapason(quaters, quater));
}
else
{
System.Console.WriteLine("Неправльный номер четверти");
}
