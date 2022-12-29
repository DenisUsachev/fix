/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.*/

int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов:");
int[,] matrix = new int[m, n];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
PrintArray(DeleteRowColoumn(matrix));



int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

void FillArrayRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int[,] DeleteRowColoumn(int[,] matrix)
{
    int min = matrix[0, 0];
    int x = 0;
    int y = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i,j];
                x = i;
                y = j;
            }
        }
    }
    int[,] newArr = new int[matrix.GetLength(0) - 1,matrix.GetLength(1) - 1];
    int a = 0;
    int b = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == x)
        continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == y)
            continue;
            newArr[a, b] = matrix[i, j];
            b++;
        }
        b = 0;
        a++;
    }
    return newArr;
}