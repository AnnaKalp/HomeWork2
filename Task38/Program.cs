/*Задача 38: Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[]numbers = new double[size];
RandomNumbers(numbers);
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        {
            max = numbers[x];
        }
    if (numbers[x] < min)
        {
            min = numbers[x];
        }
}
Console.WriteLine($"Разница между max и min элементом {max - min} ");

void RandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(10,100)) / 10;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[  ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "  ");
        }
    Console.WriteLine("]");
}