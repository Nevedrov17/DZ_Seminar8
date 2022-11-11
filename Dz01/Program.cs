Console.Clear();

Console.WriteLine("Введите количество строк :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillArray()
{
    int [,] array = new int [m ,n];
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            array[i,j] = new Random().Next(0,10);
        }
    }  
    return array;       
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }         
}

void SortArray (int [,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++ )
        {
            for (int j = 0; j < array.GetLength(1); j++ )
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }         
            }
        }
}

int [,] arr = FillArray();
PrintArray(arr);
Console.WriteLine();
SortArray(arr);
PrintArray(arr);