Console.Clear();


int [,] array1 = new int [2 ,2];
for (int i = 0; i < array1.GetLength(0); i++ )
{
    for (int j = 0; j < array1.GetLength(1); j++ )
    {
         array1[i,j] = new Random().Next(0,10);
         Console.Write($"{array1[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int [,] array2 = new int [2 ,2];
for (int i = 0; i < array2.GetLength(0); i++ )
{
    for (int j = 0; j < array2.GetLength(1); j++ )
    {
         array2[i,j] = new Random().Next(0,10);
         Console.Write($"{array2[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int [,] array3 = new int [2,2];
for (int i = 0; i < array3.GetLength(0); i++ )
{
    for (int j = 0; j < array3.GetLength(1); j++ )
    {
        int sum = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            sum = sum + array1[i,k] * array2[k,j];
        }
        array3[i,j] = sum;
        Console.Write($"{array3[i,j]} ");
    }
    Console.WriteLine();
}