/*Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */ 
{
Console.Clear();
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;
if (b == 1)
     Console.WriteLine(a);
else
{
    int Pow()
        {
            for (int i = 1; i < b; i++)
            {
                res = res * a;
            }
            return res;
        }
        Pow();
        Console.WriteLine(res);     
    }
}







