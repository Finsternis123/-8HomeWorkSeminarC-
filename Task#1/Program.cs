// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
int[,] Array = new int[5,5];
FillArray(Array);




void SortArray (int[,] Array)
{
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            int min = i;
            int min1 = j;

        for (int a = i + 1; a < Array.GetLength(1); a++)
        {
            if (Array[j,a] > Array[min1,min]) min = a;
        }
        int temp = Array[j,i];
        Array[j,i] = Array[min1,min];
        Array[min1,min] = temp;
        }
    }
}

SortArray(Array);
PrintArray(Array);








