// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] Array1 = new int[2,2];
int[,] Array2 = new int[2,2];

void PrintArray (int[,] Array1)
{
for (int i = 0; i < Array1.GetLength(0); i++)
{
    for (int j = 0; j < Array1.GetLength(1); j++)
    {
        Console.Write($"{Array1[i , j]} ");
    }
    Console.WriteLine();
}
}
void FillArray (int[,] Array1)
{
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
            Array1[i,j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray1 (int[,] Array2)
{
for (int i = 0; i < Array2.GetLength(0); i++)
{
    for (int j = 0; j < Array2.GetLength(1); j++)
    {
        Console.Write($"{Array2[i , j]} ");
    }
    Console.WriteLine();
}
}

void FillArray1(int[,] Array2)
{
    for (int i = 0; i < Array2.GetLength(0); i++)
    {
        for (int j = 0; j < Array2.GetLength(1); j++)
        {
            Array2[i,j] = new Random().Next(1, 5);
        }
    }
}
Console.WriteLine("First matrix");
FillArray(Array1);
PrintArray(Array1);
Console.WriteLine("Second matrix");
FillArray1(Array2);
PrintArray1(Array2);
Console.WriteLine("Multiplication matrix");
PrintArray(MultiMatrix(Array1, Array2));


int[,] MultiMatrix(int [,] Array1, int[,] Array2)
{
  int [,] Array3 = new int[Array1.GetLength(0), Array2.GetLength(1)];
  for (int i = 0; i < Array1.GetLength(0); i++)
  {
    for (int j = 0; j < Array2.GetLength(1); j++)
    {
      for (int a = 0; a < Array1.GetLength(1); a++)
      {
        Array3[i,j] += Array1[i,a] + Array2[a,j];
      }
    }
  }
  return Array3;
}
