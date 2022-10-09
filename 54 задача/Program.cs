/*
    Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
    двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
*/

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void NumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void ArrayFromMoreToLess(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    int max1 = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = max1;
                }
            }
        }
    }
}


Console.WriteLine("Bведите количество строк массива");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bведите количество столбцов массива");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a,b];

Console.WriteLine();
NumbersArray (array);
Console.WriteLine("Массив до изменения: ");
PrintArray (array);
Console.WriteLine();
Console.WriteLine("Массив после изменения: ");
ArrayFromMoreToLess (array);
PrintArray (array);

