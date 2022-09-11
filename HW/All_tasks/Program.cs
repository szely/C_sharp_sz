// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
Clear();
WriteLine("Введите первое число: ");
int number1 = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int number2 = int.Parse(ReadLine());
if(number1 > number2)
{
    Write("Большее число: ");
    WriteLine(number1);
    Write("Меньшее число: ");
    WriteLine(number2);
}
else
{
    Write("Большее число: ");
    WriteLine(number2);
    Write("Меньшее число: ");
    WriteLine(number1);
}


// Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using static System.Console;
Clear();
WriteLine("Введите первое число: ");
int number1 = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int number2 = int.Parse(ReadLine());
WriteLine("Введите третье число: ");
int number3 = int.Parse(ReadLine());
int max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;
Write("Максимальное число ");
WriteLine(max);


// Задача 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
using static System.Console;
Clear();
WriteLine("Введите число: ");
int number1 = int.Parse(ReadLine());
if(number1 % 2 == 0)
{
    Write(number1);
    WriteLine(" - число четноe");
}
else
{
    Write(number1);
    WriteLine(" - число нечетноe");
}


// Задача 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using static System.Console;
Clear();
WriteLine("Введите число больше 1: ");
int N = int.Parse(ReadLine());
if(N <= 1)
{
    WriteLine("Введите число больше 1!!!: ");
}
else
{
   int M = 1;
   WriteLine("Четные числа от 1 до введенного числа: ");
   while(M <= N)
   {
    if(M % 2 == 0)
    {
        WriteLine(M);
        M ++;
    }
    else
    {
        M ++;
    }
   }
}


