// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] firstArray = Create2DArray(m, n);
Print2DArray(firstArray);

Console.WriteLine();

int[,] secondArray = Create2DArray(m, n);
Print2DArray(secondArray);

Console.WriteLine("Произведение матриц равно: ");


int[,] resultArray = GetProductOfTwoMatrices(firstArray, secondArray);
Print2DArray(resultArray);



void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetProductOfTwoMatrices(int[,] array, int[,] array2)
{
    int[,] resultArray = new int[array.GetLength(0), array2.GetLength(1)];

    for (var i = 0; i < resultArray.GetLength(0); i++)
    {
        for (var j = 0; j < resultArray.GetLength(1); j++)
        {
            for (var l = 0; l < resultArray.GetLength(1); l++)
            {
                resultArray[i,j] += array[i,l] * array2[l,j];
            }
        }
    }
    return resultArray;

}
int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 4);

        }
    }

    return array;
}