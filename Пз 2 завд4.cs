using System;

class Program
{
static void Main(string[] args)
{
int[,] matrix = new int[9, 9]; // створюємо матрицю розміром 9 на 9
    // заповнюємо матрицю випадковими числами в діапазоні від 1 до 100
    Random random = new Random();
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            matrix[i, j] = random.Next(1, 101);
        }
    }

    // виводимо початкову матрицю на екран
    Console.WriteLine("Початкова матриця:");
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    // створюємо одновимірний масив для зберігання відсортованих значень матриці
    int[] sortedValues = new int[81];
    int k = 0;
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            sortedValues[k++] = matrix[i, j];
        }
    }

    // сортуємо масив зі значеннями матриці в порядку зростання
    Array.Sort(sortedValues);
    Array.Reverse(sortedValues);

    // створюємо нову матрицю зі значеннями спіралі
    int[,] spiralMatrix = new int[9, 9];
    int startRow = 0, endRow = 8, startCol = 0, endCol = 8;
    int idx = 0;

    while (startRow <= endRow && startCol <= endCol)
    {
        // додаємо верхній ряд
        for (int i = startCol; i <= endCol; i++)
        {
            spiralMatrix[startRow, i] = sortedValues[idx++];
        }
        startRow++;

        // додаємо правий стовпець
        for (int i = startRow; i <= endRow; i++)
        {
            spiralMatrix[i, endCol] = sortedValues[idx++];
        }
        endCol--;

        // додаємо нижній ряд (зправа наліво)
        if (startRow <= endRow)
        {
        for (int i = endCol; i >= startCol; i--)
        {
        spiralMatrix[endRow, i] = sortedValues[idx++];
        }
        endRow--;
        }
        // додаємо лівий стовпець (знизу вгору)
        if (startCol <= endCol)
        {
            for (int i = endRow; i >= startRow; i--)
            {
                spiralMatrix[i, startCol] = sortedValues[idx++];
            }
            startCol++;
        }
    }

    // виводимо матрицю спіралі на екран
    Console.WriteLine("\nМатриця спіралі:");
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            Console.Write(spiralMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
    Console.ReadKey();
    }
}