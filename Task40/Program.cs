/*Задача.Напишите программу, которая принимает на вход число и
выдаёт количество цифр в числе.Использовать рекурсию
456->3
78->2
89126->5*/

/*Console.Clear();

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");
int CountDigits(int number, int counter = 0)
{
    if (number / 10 ==0)
    {
        return counter + 1;
    }
    else
    {
        return counter + CountDigits(number / 10) +1;
    }
}
2-ой способ:
Console.Clear();

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(CountNumber(number));

int CountNumber(int num)
{
    if (num / 10 < 1) return 1;
    else return 1 + CountNumber(num/10);
}*/

/*Задача.Напишите программу, которая будет рекурсивно выводить
каждый элемент массива в консоль.*/

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void RecPrintArray(int[] array, int index = 0)
{
    if (index < array.Length)
    {
        Console.Write($"{array[index]} ");
        index++;
        RecPrintArray(array, index);
    }
}
