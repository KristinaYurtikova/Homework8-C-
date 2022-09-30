// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int height = EnterInt("Введите количество столбцов массива: ");  
int width = EnterInt("Введите количество строк массива: "); 

int[,] matrix = new int[height, width];
CreateRandom2DArray(matrix, height, width);
Print2DArray(matrix, height, width);
SortsRowsElementsDescending(matrix, height, width);
Console.WriteLine();
Print2DArray(matrix, height, width);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}
void CreateRandom2DArray(int[,] matrix, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            matrix [i, j] = new Random().Next(-20, 20);
        }
    }
}
void SortsRowsElementsDescending(int[,] matrix, int height, int width)
        {
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)  
      {
        for (int j = 0; j < width; j++)          {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}