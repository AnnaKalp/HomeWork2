/*Задача39:Напишите программу, которая принимает на вход
число(А) и выдаёт сумму чисел от 1 до А.
Использовать рекурсию
7->28
4->10
8->36*/

/*Console.Clear();

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Sum: {RecSum(number)}");

int RecSum(int number, int currentNumber = 1)
{
    if (currentNumber < number)
    {
        currentNumber++;
        int sum = RecSum(number, currentNumber);
        return currentNumber + sum - 1;
    }
    else
    {
        return number;
    }
}*/


//второй способ
Console.Clear();

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Sum: {RecSum(number)}");

int RecSum(int number)
{
    if (number > 1)
    {
        return number + RecSum(number - 1);
    }
    else
    {
        return 1;
    }
}
