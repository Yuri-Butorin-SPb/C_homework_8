// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = Create2DArray(m, n);
Print2DArray(array);
Console.WriteLine();
SortArray(array);
Print2DArray(array);


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

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);

        }
    }

    return array;
}


void SortArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var l = j + 1; l < array.GetLength(1); l++)
            {
                if (array[i,j] < array[i,l])
                {
                    int t = array[i,j];
                    array[i,j] = array[i,l];
                    array[i,l] = t;
                }
            }
        }
    }
}


