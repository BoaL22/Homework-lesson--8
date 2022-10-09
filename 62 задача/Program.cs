/*
    Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[size,size];


void RandomNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( array[i,j] < 10) Console.Write($"0{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}


RandomNumbersArray(array);
PrintArray(array);
