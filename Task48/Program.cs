//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится
//  по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

int[,] Array(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = i + j;
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

int[,] array = Array(row, column);
PrintArray(array);

