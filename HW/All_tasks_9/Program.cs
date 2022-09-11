// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.
// M = 1; N = 5. -> ""5,4,3,2,1""
// M = 4; N = 8. -> ""8,7,6,5,4""

using static System.Console;
using System.Linq;
Clear();

Write("Введите число N: ");
int numFirst = int.Parse(ReadLine());
Write("Введите число M: ");
int numSecond = int.Parse(ReadLine());
WriteLine($"{GetStringNumbers(numFirst, numSecond)}");

string GetStringNumbers(int n, int m)
{
    return (n == m) ? $"{n}" : n < m ? GetStringNumbers(n + 1, m) + $" {n}" : GetStringNumbers(m + 1, n) + $" {m}";
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
using System.Linq;
Clear();

Write("Введите число N: ");
int numFirst = int.Parse(ReadLine());
Write("Введите число M: ");
int numSecond = int.Parse(ReadLine());
WriteLine($"{GetSumNumbers(numFirst, numSecond)}");

int GetSumNumbers(int n, int m)
{
    return (n == m) ? n : n < m ? GetSumNumbers(n + 1, m) + n : GetSumNumbers(m + 1, n) + m;
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


using static System.Console;
using System.Linq;
Clear();

Write("Введите число m: ");
int numFirst = int.Parse(ReadLine());
Write("Введите число n: ");
int numSecond = int.Parse(ReadLine());
WriteLine($"{Ackermann(numFirst, numSecond)}");

int Ackermann(int m, int n)
{
    return (m==0)?n + 1:((m > 0) && (n == 0))?Ackermann(m - 1, 1):Ackermann(m - 1, Ackermann(m, n - 1));
}
