Console.Clear();


int [,] array = new int [2 ,2];
for (int i = 0; i < array.GetLength(0); i++ )
{
    for (int j = 0; j < array.GetLength(1); j++ )
    {
         array[i,j] = new Random().Next(0,10);
         Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int [,] array1 = new int [2 ,2];
for (int i = 0; i < array.GetLength(0); i++ )
{
    for (int j = 0; j < array.GetLength(1); j++ )
    {
         array[i,j] = new Random().Next(0,10);
         Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

int [,] array2 = new int [2,2];
for (int i = 0; i < array2.GetLength(0); i++ )
{
    for (int j = 0; j < array2.GetLength(1); j++ )
    {
         array[i,j] = array[i,j]*array1[j,i];
         Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}