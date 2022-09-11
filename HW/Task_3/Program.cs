using static System.Console;
// Задача 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
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