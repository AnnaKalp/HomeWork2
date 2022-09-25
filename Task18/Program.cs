//Задача 18: Напишите программу, которая по заданному
// номеру четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Write("Введите номер четверти:");
int num = int.Parse(Console.ReadLine()!);
if (num < 1 || num > 4)
    Console.Write("Существует всего 4 четверти:");

else if (num == 1)
{
    Console.Write("X и Y больше 0");
}
else if (num == 2)
{
    Console.Write("X меньше 0,Y больше 0");
}
else if (num == 3)
{
    Console.Write("X меньше 0,Y меньше 0");
}
else
{
    Console.Write("X больше 0, Y меньше 0");
}



