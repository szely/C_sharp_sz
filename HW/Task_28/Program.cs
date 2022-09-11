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