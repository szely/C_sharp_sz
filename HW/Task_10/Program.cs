// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using static System.Console;
Clear();
WriteLine("Число N: ");
int n = int.Parse(ReadLine());
for(int index = 1; n >= index;  index++)
{
    int cube = index * index * index;
    WriteLine($"{index}^3 = {cube}");
}

