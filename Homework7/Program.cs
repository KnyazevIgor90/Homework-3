/*
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomDouble2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] =Math.Round(new Random().NextDouble()+ new Random().Next(minValue, maxValue + 1),1);
    return newArray;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandomDouble2dArray(m, n, min, max);
Show2dArray(myArray);


*/

/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandomDouble2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] =new Random().Next(minValue, maxValue + 1);
            
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}


void FindNumber(int[,] array, int IndexRow, int IndexColumn)
{
    if(IndexRow >= 0 && IndexRow<array.GetLength(0) && 
       IndexColumn >= 0 && IndexColumn<array.GetLength(1))

    Console.WriteLine($"This number, with coordinate {IndexRow},{IndexColumn} is {array[IndexRow,IndexColumn]}");
    else Console.WriteLine($"Error: this number with coordinates {IndexRow},{IndexColumn} is not find.");
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input find number in row (row begin to 0): ");
int NumberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input find number in column (column begin to 0): ");
int NumberColum = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandomDouble2dArray(m, n, min, max);
Show2dArray(myArray);


FindNumber(myArray, NumberRow, NumberColum);
*/

/*
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
double[] AverageSumColumns(int[,] array)
{
    double[] avg=new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum=0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum=sum+array[i,j];
        }
        avg[j]=sum/array.GetLength(0);
    }
return avg;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine("The averages sum of columns is:");
double [] a=AverageSumColumns(myArray);
ShowArray(a);
Console.WriteLine();

*/