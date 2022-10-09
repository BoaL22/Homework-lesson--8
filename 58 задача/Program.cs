/*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
*/


Console.Write("Размерность матриц: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[size,size];
int[,] matrixB = new int[size,size];
RandomNumbersArray(matrixA);
RandomNumbersArray(matrixB);

int[,] matrixC = new int[size,size];


void RandomNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
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
            Console.Write($"{array[i,j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void PrintСompositionArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( array[i,j] < 100) Console.Write($"0{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}


Console.WriteLine();
Console.WriteLine("Первая матрица: ");
PrintArray(matrixA);
Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
PrintArray(matrixB);
Console.WriteLine();

Console.WriteLine("Произведение двух матриц: ");
PrintСompositionArray(matrixC);
Console.WriteLine();
