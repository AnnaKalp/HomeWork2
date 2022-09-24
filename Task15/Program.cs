//Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
//  является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите число, обозначающее день недели: ");
int daynumber = Convert.ToInt32(Console.ReadLine());

   if(daynumber < 1 || daynumber > 7)
{
Console.WriteLine("Это число не обозначает день недели. Введите число от 1 до 7");
}
   else if (daynumber < 6)
{
Console.WriteLine("не является выходным днем");
}
    else
{
Console.WriteLine("это выходной день");
}