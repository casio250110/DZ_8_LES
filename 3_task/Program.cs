// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] firstMatrix = new int[4, 4];
int[,] secondMatrix = new int[4, 4];
int[,] resultMatrix=new int[4,4];

void FillArray(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            firstMatrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void MultiMatrix(int[,]firstMatrix,int[,]secondMatrix,int[,]resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int matr=0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                matr += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i,j]=matr;
        }
    }
}

void PrintArray(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write($"{firstMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
PrintArray(secondMatrix);
Console.WriteLine();
MultiMatrix(firstMatrix,secondMatrix,resultMatrix);
PrintArray(resultMatrix);