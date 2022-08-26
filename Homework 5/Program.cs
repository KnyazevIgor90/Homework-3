
/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100,1000);
    
    return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int CountEvenNumbers (int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            count++;
    return count;
}




Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
Console.WriteLine($"Count even elements: {CountEvenNumbers(myArray)}");

*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


int FindSumOddNumbers(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if (i % 2 != 1)
            result += array[i];
    return result;
    
}


Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value to element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value to element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
Console.WriteLine($"Summ elements with odd positions: {FindSumOddNumbers(myArray)}");


*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindMaxBeetweenMin(int [] array)
{
    int maxnum = array[0];
    int minnum = array[0];
    int result = 0;
       for (int i=0; i<array.Length; i++)
    {
        if(array[i]<=minnum) minnum=array[i];     
        if(array[i]>=maxnum) maxnum=array[i];
        
    result = maxnum - minnum;
    }

Console.WriteLine($"Max number - min mumber is {result}");      
return result;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value to element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value to element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMaxBeetweenMin(myArray);