// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

using static System.Console;

// int[] array = new int[8];

int[] array = FillArray(8);
PrintArrayT(array);

// void GetArray(int[] arr)
// {
//     int length = arr.Length;
//     for(int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }
// }



// void PrintArray(int[] mass)
// {
//     WriteLine($"[{String.Join(",",mass)}]");
// }

int[] FillArray (int n)
{
    int[] arr = new int[n];
    for( int i = 0; i < arr.Length; i++)
    {
    arr[i] = new Random().Next(0,2);
    }
    return arr;
}

void PrintArrayT(int[] mass)
{
    Write("[");
    for(int j = 0; j < mass.Length; j++)
    {
        Write($"{mass[j]}");
        if(j < mass.Length - 1)
        {
            Write(",");
        }
    }
   WriteLine("]");
}


