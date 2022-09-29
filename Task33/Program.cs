// Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
// 4; массив[6,7,19,345,3]->нет
//-3; массив[6,7,19,345,3]->да

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[10];
FillArray(array);
PrintArray(array);
if(FindNumberInArray(array, num))
   Console.Write($"число {num} присутствует в массиве");
else
   Console.Write($"число {num} отсутствует в массиве");

bool FindNumberInArray(int[] array, int num)
{
    for (int i = 0; i <10; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < 10; i++)
    {
        array[i] = randGenerator.Next(0, 10);
    }
}
    
void PrintArray(int[] array)
 {
    int count =array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count-1)
           Console.WriteLine("]");
           else
           Console.Write(", ");
    }
 }  
