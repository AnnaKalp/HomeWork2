/*Задача 58: Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.*/

int[,] matrix = new int[4, 4];
int[,] matrix1 = new int[4, 4];
int[,] compMatrix = new int[4, 4];
FillArray(matrix, matrix1);
PrintArray(matrix, matrix1);
Console.WriteLine();
Composition(matrix, matrix1, compMatrix);
PrintCompArray(compMatrix);
void FillArray(int[,] matrix, int[,] matrix1)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix, int[,] matrix1)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] matrix, int[,] matrix1, int[,] compMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            compMatrix[i, j] = matrix[i, j] * matrix1[i, j];
        }
    }
}

void PrintCompArray(int[,] compMatrix)
{
    for (int i = 0; i < compMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < compMatrix.GetLength(1); j++)
        {
            Console.Write($"{compMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
