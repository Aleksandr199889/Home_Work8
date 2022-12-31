// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите колличество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rowCount, columnCount];

void FillArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray( int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] +  " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
void FillArray1( int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for ( int z = j+1; z < arr.GetLength(1); z++)
            {
                if (arr[i,z] > arr[i,j])
                {
                    int temp = arr[i,z];
                    arr[i,z] = arr[i,j];
                    arr[i,j] = temp;
                }
            }
        }
    }
}

void PrintArray1( int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] +  " ");
        }
        Console.WriteLine();
    }
}

FillArray1(array);
PrintArray1(array);