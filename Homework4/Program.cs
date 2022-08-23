/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double ShowPow(int a, int b)
{
    int Pow = 1; 
    for (int i = 0; i < b; i++)
    {
        Pow = Pow * a;
    }
    return Pow;
}

Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {a} in {b} Pow is {ShowPow(a, b)}");

*/
/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSumDigits(int number)
{
    int counter = Convert.ToString(number).Length;
    int sum = 0;
    int inter = 0;
for(int i = 0; i < counter; i++)
{
    inter = number - number % 10;
    sum = sum + (number - inter);
    number = number / 10;
}
    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits = FindSumDigits(number);
Console.Write("Sum digits in number: " + SumDigits);
*/

/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
int count = array.Length;
    for (int i = 0; i < count; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
PrintArray(arr);

*/


int[] CreateRandomArray(int minValue, int maxValue)
{
    int[] newArray = new int[8];
    
    for (int i = 0; i < 8; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input min possible value to element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value to element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(min, max);
ShowArray(myArray);
