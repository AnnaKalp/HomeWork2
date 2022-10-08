/*Задача49:Задайте двумерный массив.Найдите элементы,у которых
 оба индекса чётные, и замените эти элементы на их квадраты.*/

int[,] array = new int[5, 5];

FillArray(array);
PrintArray(array);
Console.WriteLine("");
ReplaceArray(array);
PrintArray(array);

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

void ReplaceArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            //array[i, j] = array[i, j] * array[i, j];
            array[i, j] = (int)Math.Pow(array[i,j], 2);//2-ой способ
        }
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



