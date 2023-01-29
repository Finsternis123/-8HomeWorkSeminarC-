// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Array = new int[4,6];
void PrintArray (int[,] Array)
{
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Console.Write($"{Array[i , j]} ");
    }
    Console.WriteLine();
}
}
void FillArray (int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(1, 100);
        }
    }
}

FillArray(Array);
PrintArray(Array);
Console.WriteLine();

int min = 0;
int sum = sum1(Array, 0);
for (int i = 1; i < Array.GetLength(0); i++)
{
  int temp = sum1(Array, i);
  if (sum > temp)
  {
    sum = temp;
    min = i;
  }
}
Console.WriteLine($"{min+1} = строкa с наименьшей суммой");

int sum1(int[,] Array, int i)
{
  int sum = Array[i,0];
  for (int j = 1; j < Array.GetLength(1); j++)
  {
    sum += Array[i,j];
  }
  return sum;
}


