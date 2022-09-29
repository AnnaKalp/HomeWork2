/*Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();
Console.Write("Введите размер массива 8: ");
int arrayLenght = int.Parse(Console.ReadLine()!);
int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] array0)
{
    Random randGenerator = new Random();
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = randGenerator .Next(0, 99);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    
    }

}