// Задача 1: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
// создаём двумерный массив со случайным количеством строк и столбцов (1 - 10)
int columns = new Random().Next(1, 11);
int lines = new Random().Next(1, 11);
int[,] matrix = new int[lines, columns];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);

// спрашиваем координаты элемента
Console.Write("\nВведите позицию элемента: ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
if (matrix.GetLength(0) > position[0])
{
    if (matrix.GetLength(1) > position[1])
    {
        Console.WriteLine($"Вот этот элемент: {matrix[position[0], position[1]]}");
    }
    else Console.WriteLine("Такого элемента нет");
}
else Console.WriteLine("Такого элемента нет");