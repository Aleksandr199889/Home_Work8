// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int min = Int32.MaxValue;
int count = Int32.MaxValue;
int[] arra = new int[b];
int[,] arr = new int[a, b];
void PrintArray(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j]);
        }
    Console.WriteLine();
    }
}
void Print(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
    arra[i] = sum;
    }

    for (int i = 0; i < arra.Length; i++)
    {
        Console.Write(" " + arra[i]);
    }
    Console.WriteLine();

    for (int i = 0; i < arra.Length; i++)
    {
        if (arra[i] < min)
        {
            min = arra[i];
            count = i;
        }
    }
    Console.WriteLine(count + 1 + " строка");
}
PrintArray(arr);
FillArray(arr);
Print(arr);