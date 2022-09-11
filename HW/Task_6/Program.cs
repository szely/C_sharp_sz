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
