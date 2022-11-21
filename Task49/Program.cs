//// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.


Console.Clear();

int[,] Array(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(min, max);
            if (i % 2 == 0 && j % 2 == 0)
            {
                result[i, j] = (result[i, j]) * (result[i, j]);
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


