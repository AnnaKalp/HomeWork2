/*Задача 68: Напишите программу вычисления функции Аккермана с
 помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int PrintNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

int m = PrintNumber("Ввести число m: ");
int n = PrintNumber("Ввести число n: ");
int ack = Ackerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {ack} ");

