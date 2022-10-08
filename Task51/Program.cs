/*Задача51:Задайте двумерный массив.Найдите сумму элементов,
находящихся на главной диагонали(с индексами(0.0);(1,1)и т.д.)*/

int[,] array = new int[5, 5];

FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали = {SumOfDiaArray(array)}");

int SumOfDiaArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + array[i, j];
        }
    }
    return sum;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");

    }
}

void FillArray(int[,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}



