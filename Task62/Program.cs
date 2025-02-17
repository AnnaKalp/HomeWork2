﻿/*Задача 62. Напишите программу, которая заполнит спирально массив
 4 на 4.*/

Console.WriteLine($"Заполнить спирально массив 4 на 4:");

int n = 4;
int m = 4;
int[,] squareMatrix = new int[n, m];


int temp = 1;
int i = 0;
int j = 0;

while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
{
    squareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(squareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}