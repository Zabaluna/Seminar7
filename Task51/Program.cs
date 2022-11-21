//Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


Console.Clear();

int diagSum = 0;
int[,] Array(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(min, max);
            if (i == j)
            {
                diagSum += result[i, j];
            }
        }
    }

    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество стоблцов массива: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное число в массиве: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число в массиве: ");
int max = int.Parse(Console.ReadLine());

int[,] array = Array(row, column, min, max);
PrintArray(array);
Console.WriteLine($"Сумма элементов на главной диагонали: {diagSum}");


