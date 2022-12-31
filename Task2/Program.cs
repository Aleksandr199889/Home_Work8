int rowCount = 2;
int columnCount = 2;
int [,] arrayA = new int [rowCount, columnCount];
int [,] arrayB = new int [rowCount, columnCount];

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
            Console.Write(arr[i, j] + " ");
        }   
    Console.WriteLine();
    }
}

FillArray(arrayA);
PrintArray(arrayA);
Console.WriteLine();
FillArray(arrayB);
PrintArray(arrayB);
Console.WriteLine();

void FillArray1( int[,] arr, int[,] arr1)
{
    var arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];

            }
        Console.Write(arrayC[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray1(arrayA,arrayB);
Console.Write("Введите число, ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, ");
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
    Console.WriteLine(count + 1);
}
PrintArray(arr);
FillArray(arr);
Print(arr);