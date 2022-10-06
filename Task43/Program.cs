/*Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
 y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double X;
double Y;

Console.Write("Даны 2 прямые заданные уравнениями: y = k1 * x + b1,  y = k2 * x + b2");
Console.WriteLine();
Console.Write("Введите b1, k1, b2 и k2 через пробел: ");

int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr [1];
int b = arr [3];
int c = arr [0];
int d = arr [2];

X = (double) (d-c)/(a-b);
Y = (double) a*(d-c)/(a-b) + c;

Console.WriteLine("Точки пересечения двух прямых:");
Console.WriteLine($"Х: {X:0.00}");
Console.WriteLine($"Y: {Y:0.00}");
