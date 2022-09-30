// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int height = EnterInt("Введите количество столбцов массива: "); 
int width = EnterInt("Введите количество строк массива: "); 


int[,] matrix1 = new int[height, width];
int[,] matrix2 = new int[height, width];
int[,] resultmatrixes = new int[height, width];

CreateRandom2DArray(matrix1);
Print2DArray(matrix1);
CreateRandom2DArray(matrix2);
Console.WriteLine();
Print2DArray(matrix2);
MultiplyTwoMatrixes(matrix1, matrix2, resultmatrixes);
Console.WriteLine();
Print2DArray(resultmatrixes);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void CreateRandom2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void MultiplyTwoMatrixes(int[,] matrix1, int[,] matrix2, int[,] resultmatrexes)
{
    if (matrix1.GetLength(0) != matrix2.GetLength(1))
    {
        Console.WriteLine("Нельзя перемножить");
    }  
    else
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                resultmatrexes[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    resultmatrexes[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
}