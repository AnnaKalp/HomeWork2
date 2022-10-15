/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
 Рекурсивно
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

FindIntegers(n, m);

void FindIntegers(int n, int counter = 1)
{
    counter++;
    Console.WriteLine(counter);
    if (counter >= n)
    {
        return;
    }
    FindIntegers(n, counter);
}
