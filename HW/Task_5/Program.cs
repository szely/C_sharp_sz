//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
using static System.Console;
Clear();
WriteLine("Введите трехзначное число: ");
int number = int.Parse(ReadLine());
if(number < 100 || number > 999)
{
    WriteLine("Введите все таки трехзначное число");
}
else
{
    int digital = number % 100 / 10;
    WriteLine($"{digital} - вторая цифра в числе");
}