// Задача 3: Задайте две квадратные матрицы одинакового размера. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица:
// 18 20
// 15 18

// c11 = a11·b11 + a12·b21 = 2·3 + 4·3 = 6 + 12 = 18

// c12 = a11·b12 + a12·b22 = 2·4 + 4·3 = 8 + 12 = 20

// c21 = a21·b11 + a22·b21 = 3·3 + 2·3 = 9 + 6 = 15

// c22 = a21·b12 + a22·b22 = 3·4 + 2·3 = 12 + 6 = 18



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
            Console.Write(arr[i, j] +  " ");
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
            Console.Write(arrayC[i, j] +  " ");
           
        }
         Console.WriteLine();
         
    }
}

FillArray1(arrayA,arrayB);