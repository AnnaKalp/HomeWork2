/*Задача 41: Пользователь вводит с клавиатуры число M, 
потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько
 чисел больше 0 ввёл пользователь.*/

/* 1-ый способ:
Console.Clear();
 
int numberCount = int.Parse(Console.ReadLine()!);
int counter = 0;
 
for (int i = 0; i < numberCount; i++)
{
    int currentNumber = int.Parse(Console.ReadLine()!);
    if (currentNumber > 0)
    {
        counter++;
    }
}
 
Console.WriteLine(counter);*/
 
 
 
 
Console.Clear();
 
int numberCount = int.Parse(Console.ReadLine()!);
int[] numberArray = new int[numberCount];
 
for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = int.Parse(Console.ReadLine()!);
}
 
Console.WriteLine(CountPositiveNumbers(numberArray));
 
 
int CountPositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}