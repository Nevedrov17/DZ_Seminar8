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



int [,] arr = FillArray();
PrintArray(arr);
Console.WriteLine();

int sum = 0;
int [] array1 = new int [m];

    for (int i = 0; i < arr.GetLength(0); i++ )
    {
        for (int j = 0; j < arr.GetLength(1); j++ )
        {
            sum = sum +  arr[i,j];
        }
        array1[i] = sum;
        Console.Write($"{array1[i]} ");
        sum = 0;
    }  
    int min = array1[0];
    int index = 0;
    for (int i = 1; i < array1.Length; i++ )
    {
        if( min > array1[i])
        {
            min = array1[i];
            index = i;         
        }
    }
    Console.WriteLine($"Наименьшая сумма в {index + 1} строке");

