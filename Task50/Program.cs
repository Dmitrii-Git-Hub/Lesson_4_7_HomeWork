// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArrayElement(int[,] arr, int row, int col)
{
    if (row >= arr.GetLength(0) || col >= arr.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.Write(arr[row, col]);
    }
}

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetNumberFromConsole("Введите введите позицию <<m>> элемента в массиве ");
int n = GetNumberFromConsole("Введите введите позицию <<n>> элемента в массиве ");
int[,] array = new int[3, 4];
FillArray(array);
PrintArrayElement(array, m, n);