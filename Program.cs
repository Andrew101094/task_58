// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк для матрицы 1: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для матрицы 1: ");
int columns1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] matrix1 = GetMatrix1(rows1, columns1, 1, 9); 
PrintMatrix(matrix1);
Console.WriteLine();

Console.Write("Введите количество строк для матрицы 2: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для матрицы 2: ");
int columns2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] matrix2 = GetMatrix2(rows2, columns2, 1, 9);
PrintMatrix(matrix2); 
Console.WriteLine();

int[,] matr = MultiplierMatrix(matrix1, matrix2);
Console.WriteLine("Произведение матриц: ");
PrintMatrix(matr); 
int[,] GetMatrix1 (int a, int b, int min, int max)
{
    int[,]result1 = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result1[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result1;
}

int[,] GetMatrix2 (int c, int d, int min, int max)
{
    int[,]result2 = new int[c, d];
    for (int i = 0; i < c; i++)
    {
        for (int j = 0; j < d; j++)
        {
            result2[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result2;
}

int[,] MultiplierMatrix(int [,] matrix1, int [,] matrix2)
{
    int[,] multiplier = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                multiplier[i, j] = multiplier[i, j] + matrix1[i, k]*matrix2[k, j];
            }
        }
    }
    return multiplier;
}

void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}