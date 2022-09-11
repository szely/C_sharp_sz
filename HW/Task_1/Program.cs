using static System.Console;
// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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