/*Задача44:Напишите программу, которая принимает на вход 2 числа,
количество строк и количество столбцов,nсоздаёт матрицу данного 
размера и заполняет нулями или единицами в случайном порядке
и выводит на консоль.*/

int[,] CreateArray(int row, int colomn)
{
    int[,] array = new int [row, colomn];
    return array;
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(0,2);
        }
    }   
}
void PrintArray(int[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for(int colomns = 0; colomns < arr.GetLength(1); colomns++)
        {
            Console.Write($"| {arr[rows, colomns]} |");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int colomn = int.Parse(Console.ReadLine()!);

int[,] ar = CreateArray(row, colomn);
FillArray(ar);
PrintArray(ar);

