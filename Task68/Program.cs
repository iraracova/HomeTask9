// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите неотрицательное число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число n:");
int n = Convert.ToInt32(Console.ReadLine());

int res = AckermannFunction(m, n);
Console.WriteLine(res);

 int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else
    if ((m != 0) && (n == 0))
    return AckermannFunction(m - 1, 1);
    else
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}