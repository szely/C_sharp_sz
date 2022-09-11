using static System.Console;
// Задача 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
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