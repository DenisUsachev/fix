/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
 на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GenerateRandomMatrix(int min, int max, int m, int n)
{
    int[,] matrix = new int[m, n];
    Random r = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = r.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] DeleteMinRowColoumn(int[,] matrix)
{
    int minnum = matrix[0,0];
    int x = 0;
    int y = 0;

    for (int i = 0; i < matrix.Getlength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < minnum)
            {
                minnum = matrix[i,j];
                x = i;
                y = j;
            }
        }
    }
    int[,] newArr = new int[matrix.GetLength(0) - 1,matrix.GetLength(1) - 1];
    int a = 0;
    int b = 0;

    for (int i = 0; i < matrix.Getlength(0); i++)
    {
        if(i == x)
            continue;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j == y)
                continue;
            new Arr[a, b] = matrix[i, j];
            b++;
        }
        b = 0;
        a++;
    }
}

