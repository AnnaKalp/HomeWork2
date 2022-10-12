/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.*/


int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Sum(int[,] matrix)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += matrix[i, j];
                minSum += matrix[i, j];
            }
            else sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: " + Sum(matrix));