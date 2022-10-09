/*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:

    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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

void MinSumNumbersArray(int[,] array)
{
    int minSum = Int32.MaxValue;
    int line = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            line++;
        }
        Console.WriteLine($"Сумма {i+1} строки = {sum}");
    }
    Console.WriteLine();
    Console.WriteLine("Cтрока с наименьшей суммой элементов под номером: " + (line) + ", с суммой елементов равной: " + (minSum));
}



Console.WriteLine("Введите количество строк и столбцов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a,a];

RandomNumbersArray(array);
PrintArray(array);
Console.WriteLine();
MinSumNumbersArray(array);
Console.WriteLine();