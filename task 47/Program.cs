// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] GenerateMatrix()
{
    Console.WriteLine("введите количество строк матрицы:  ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов матрицы:  ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] matrix = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(10, 100)) / 10;
        }
    }
    return matrix;

}
void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "   ");
        }
        System.Console.WriteLine();
    }
}
var myMatrix = GenerateMatrix();
PrintMatrix(myMatrix);