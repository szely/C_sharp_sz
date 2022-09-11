using static System.Console;
// Задача 3
Clear();
WriteLine("Введите число: ");
int number = int.Parse(ReadLine());
int i = -number;
while(i <= number)
{
    WriteLine(i);
    i++;
} 