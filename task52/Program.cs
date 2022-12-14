//  Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] MatrixArray(int line, int colums, int min, int max)
{
    int[,] matrix = new int[line, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4},");
            else Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine("|");
    }

}

double[] MiddleArifmetic(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] result = new double[size];
     int ix= 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result[ix] += matrix[i, j];
          


        }
    result[ix] =Math.Round( (result[ix] / matrix.GetLength(0)),4);

     ix++;

    }

    return result;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i], 2},  ");
        else Console.Write($"{arr[i],2}");
    }
    Console.WriteLine("]");
}

int[,] matrixArray = MatrixArray(2, 5, 1, 5);
PrintMatrix(matrixArray);
double[] middleArifmetic = MiddleArifmetic(matrixArray);

PrintArray(middleArifmetic);

 