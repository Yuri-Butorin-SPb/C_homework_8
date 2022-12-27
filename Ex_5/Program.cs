// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = Create2DArray(m, n);
Print2DArray(array);
Console.WriteLine();
SpiralArray(array);
Print2DArray(array);



void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}



void SpiralArray(int[,] array)
{
    int num = 1;
    int var = 0;
    int x = array.GetLength(0);

    for (var = 0; var < array.GetLength(0) -2; var++)
    {
    for (int i = 0 + var; i < array.GetLength(1) - var; i++)
    {
        array[0 + var, i] = num;
        num++;
    }
    num--;

    for (int i = 0 + var; i < array.GetLength(0) - var; i++)
    {
        array[i, x - 1 - var] = num;
        num++;
    }
    num--;
    
    for (int i = x-1 - var; i >= 0 + var; i--)
    {
        array[x - 1 - var, i] = num;
        num++;
    }
    num--;

    for (int i = x-1 - var; i > 0 + var; i--)
    {
        array[i, 0 + var] = num;
        num++;
    }
    }

}




