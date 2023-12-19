// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.



// Метод считает сумму элементов строки массива
int Sum(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}


Console.Clear();
// Создаём массив и выводим его на экран

int x = new Random().Next(1, 11);
int y = new Random().Next(1, 11);
int[,] matrix = new int[x, y];

for (int i = 0; i < x; i++)
{
    for(int j = 0; j < y; j++)
    {
        matrix[i, j] = new Random().Next(1, 101);
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

// Ищем строку с наименьшей суммой
int MinimumLine = 0;
int SumOfLine = Sum(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int temp = Sum(matrix, i);
    if (SumOfLine > temp)
    {
        SumOfLine = temp;
        MinimumLine = i;
    }
}
MinimumLine = MinimumLine + 1;

// Результат
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой: {MinimumLine}");
