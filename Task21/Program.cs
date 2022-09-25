// Задача 21: Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними 
//в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,2

Console.Write("Введите координат X для точки A:");
double xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координат Y для точки A:");
double ya = double.Parse(Console.ReadLine()!);

Console.Write("Введите координат X для точки B:");
double xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координат Y для точки B:");
double yb = double.Parse(Console.ReadLine()!);

double d = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));

Console.Write(d.ToString("#.00"));
