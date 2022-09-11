using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите массив через пробел:");

int count = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray().Where(a=>a%2!=0).Count();

WriteLine(count);