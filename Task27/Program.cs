/*Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();
Console.WriteLine("Введите число: ");
int num =Convert.ToInt32(Console.ReadLine());
int sum(int num)
{
    int counter = Convert.ToString(num).Length;
    int adv = 0;
    int res = 0;

    for (int i = 0; i < counter; i++)
    {
      adv = num - num % 10;
      res = res + (num - adv);
      num = num / 10;
    }
   return res;
  }

int sumNumber = sum(num);
Console.WriteLine("Сумма цифр:" + sumNumber);


