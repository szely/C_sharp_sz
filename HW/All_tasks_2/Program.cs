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

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
using static System.Console;
Clear();
WriteLine("Введите число: ");
int number = int.Parse(ReadLine());
if(number < 100)
{
    WriteLine("Третьей цифры нет");
}
else
{
    while(number > 999)
    {
        number = number / 10;
    }
        int digital = number % 10;
        WriteLine($"{digital} - третья цифра в числе");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
using static System.Console;
Clear();
WriteLine("Введите порядковый номер дня недели: ");
int day = int.Parse(ReadLine());
if(day > 7)
{
    WriteLine("Нет такого дня недели");
}
else
    if(day == 6 || day == 7)
    {
      WriteLine("Это выходной");
    }
    else
    {
        WriteLine("Это не выходной");
    }
