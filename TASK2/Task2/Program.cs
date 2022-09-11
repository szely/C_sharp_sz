using static System.Console;
// Задача 4
Clear();
WriteLine("Введите трехзначное число: ");
int number = int.Parse(ReadLine());
int i = -number;
while(i <= number)
{
    WriteLine(i);
    i++;
} 