//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Вводим число");
int anyNumber = Convert.ToInt32(Console.ReadLine()!);
string anyNumberIndex = Convert.ToString(anyNumber);
if (anyNumberIndex.Length > 2 )
{
  Console.WriteLine(" третья цифра " + anyNumberIndex[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}

