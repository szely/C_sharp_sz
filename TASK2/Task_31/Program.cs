// Напишите программу которая выведет все числа в промежутке от 1 до N
using static System.Console;
using System.Linq;
Clear();

Write("Введите число N: ");
int num = int.Parse(ReadLine());
WriteLine($"{GetStringNumbers1(num)}");

string GetStringNumbers(int n)
{
    if (n == 1) return "1";
    return GetStringNumbers(n - 1) + $" {n}";
}
string GetStringNumbers1(int n)
{
    return (n == 1)?"1": GetStringNumbers1(n - 1) + $" {n}";
}