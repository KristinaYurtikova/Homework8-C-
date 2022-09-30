// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int height = EnterInt("Введите количество столбцов массива: "); 
int width = EnterInt("Введите количество строк массива: "); 

int[,] matrix = new int[height, width];
CreateRandom2DArray(matrix, height, width);
Print2DArray(matrix, height, width);
FindRowWithMinSumOfElements(matrix, height, width);

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
            matrix[i, j] = new Random().Next(-20, 20);
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)  
    {
        for (int j = 0; j < width; j++) 
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int FindRowWithMinSumOfElements(int[,] matrix, int height, int width)
{
    int sum = 0;
    int minsum = 0;
    int minnum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += matrix[i, j];
                minsum = matrix[i, j];
            }
            else sum += matrix[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            minnum = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Cтрока с наименьшей суммой элементов:{minnum} ");
    return minnum;
}

