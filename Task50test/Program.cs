//  Задача 50: Напишите программу, которая на вход принимает позиции элемента 
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Создаем массив m на n как в предыдущей задаче
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

Console.WriteLine("Введите значение позиций элементов в массиве: ");
Console.Write("Индекс строки: ");
int indexrow = int.Parse(Console.ReadLine());
Console.Write("Индекс столбца: ");
int indexcolumn = int.Parse(Console.ReadLine());

if (indexrow < 0 || indexrow > array.GetLength(0) - 1 && indexcolumn < 0 || indexcolumn > array.GetLength(1) - 1)
{
    Console.WriteLine($"Элемент отсуствует в массиве ->: {indexrow}{indexcolumn} ");
}
else
{
    Console.WriteLine($"{array[indexrow, indexcolumn]}");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


