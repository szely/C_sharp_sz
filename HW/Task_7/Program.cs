﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

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
