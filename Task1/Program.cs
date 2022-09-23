//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру 
//этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Вводим трёхзначное число");
int anyNumber = Convert.ToInt32(Console.ReadLine()!);
string anyNumberIndex = Convert.ToString(anyNumber);
if (anyNumberIndex.Length > 1 )
{
  Console.WriteLine(" вторая цифра " + anyNumberIndex[1]);
}