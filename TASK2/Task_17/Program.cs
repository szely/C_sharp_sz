// Реверс массива

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите массив через пробел");
int[] array = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
int[] arr3 = new int[10].Select(x=>new Random().Next(-10,10)).ToArray();
WriteLine($"{String.Join(" ",arr3)}");
ReversArray1(array);
WriteLine($"{String.Join(" ",array)}");
ReversArray2(array);
WriteLine($"{String.Join(" ",array)}");

void ReversArray1(int[] inArray)
{
    for(int i = 0; i < inArray.Length/2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for(int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}



