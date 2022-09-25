// Задача 19: Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
string number = (Console.ReadLine()!);

void checkednumber(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine("Число является палиндромом");
  }
  else Console.WriteLine("Число не является палиндромом");
}

if (number!.Length == 5)
{
  checkednumber(number);
}
else Console.WriteLine("Нужно ввести пятизначное число");
