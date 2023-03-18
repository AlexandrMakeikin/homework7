// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
        }
    }
    return matrix;
}
void NewMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j += 1)
    {
         double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i += 1)
        {
            sum += matrix[i, j];
        }System.Console.Write($"{ sum / matrix.GetLength(0)  } ; ");
    }
}
void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int m = ReadInt("введите количество строк матрицы:  ");
int n = ReadInt("введите количество столбцов матрицы:  ");
int[,] matrix = GenerateMatrix(m, n);

PrintMatrix(matrix);
System.Console.WriteLine();
NewMatrix(matrix);

