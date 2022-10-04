/*Задача 36:  Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int x = 0; x < numbers.Length; x+=2)
    sum = sum + numbers[x];

    Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");

void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
            Console.WriteLine(" ");
}