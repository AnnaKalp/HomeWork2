//Задача 30:Напишите программу,число,создаёт массив 
//данного размера, заполняет его нулями и единицами
//в случайном порядке и выводит в консоль.
//8->[1,0,1,1,0,1,0,0]

Console.Clear();
Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

int[] array = new int[arrayLenght];

FillArray(array);
PrintArray(array);

void FillArray(int[] array0)
{
    Random randGenerator = new Random();
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}