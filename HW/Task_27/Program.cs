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