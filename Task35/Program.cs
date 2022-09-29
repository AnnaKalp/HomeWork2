//Задача35:Задайте одномерный массивиз 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат
//в отрезке[10,99].

Console.Clear();

int[] array = new int[123];
FillArray(array);
int c = GetCount(array);
Console.WriteLine($"Количество элементов от 10 до 99 равно {c}");

int GetCount(int[] arr)
{
    int count = 0;
    for(int i = 0; i < 123; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        count++;
    }
    return count;
}

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < 123; i++)
    {
        array[i] = randGenerator.Next(0, 201);
    }
}
