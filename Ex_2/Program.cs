// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = Create2DArray(m, n);
Print2DArray(array);
Console.WriteLine();
int result = MinLineOfArray(array);
Console.WriteLine($"Наименьшая сумма элементов: {result+1} строка.");


int MinLineOfArray (int[,] array)
{
    
    int[] newArray = new int[array.GetLength(0)];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;    
        for (var j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        newArray [i] = sum;
    }
    

    int minSum = newArray [0];
    int minIndex = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray [i] < minSum) 
        {
            minSum = newArray [i];
            minIndex = i;
        }
    }

    return minIndex;
}



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