// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
int[] newArray = new int[8];
GetArray(newArray);
PrintArray(newArray);




void GetArray(int [] array)
{
    int length = array.Length;
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}

void PrintArray(int [] arr)
{ 
    Console.WriteLine($"{String.Join(",",arr)}");
    Console.WriteLine($"[{String.Join(",",arr)}]");
}