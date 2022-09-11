// Напишите программу которая выведет все числа в промежутке от M до N
using static System.Console;
using System.Linq;
Clear();

Write("Введите число N: ");
int numFirst = int.Parse(ReadLine());
Write("Введите число M: ");
int numSecond = int.Parse(ReadLine());
WriteLine($"{GetStringNumbers1(numFirst, numSecond)}");

string GetStringNumbers(int n, int m)
{
    if (n > m)
    {
        return (n == m) ? $"{m}" : GetStringNumbers(n - 1, m) + $" {n}";
    }
    else
    {
        return (m == n) ? $"{n}" : GetStringNumbers(n, m - 1) + $" {m}";
    }
}

// string GetStringNumbers1(int n, int m)
// {
//     if (n == m) return $"{n}";
//     else return $"{n} "+GetStringNumbers1(n+1,m);

// }

string GetStringNumbers1(int n, int m)
{
    return (n == m) ? $"{n}" : n < m ? $"{n} " + GetStringNumbers1(n + 1, m) : $"{m} " + GetStringNumbers1(m + 1, n);
}