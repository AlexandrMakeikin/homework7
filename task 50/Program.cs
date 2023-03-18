// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matr,int rows, int colums)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
    
}

int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 6];
FillArray(numbers);
 PrintMatrix(numbers,rows,colums);
 System.Console.WriteLine();
if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine($"элемент массива = {numbers[rows, colums]}");
else Console.WriteLine($"[{rows},{colums}] -> такого элемента в массиве нет");