/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Show2ndNumber(int number)
{
    int dec = number /10;
    int reminder = dec % 10;

    return reminder;
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int newNumber = Show2ndNumber(n);
Console.WriteLine($"New version of {n} is {newNumber}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdDigit(int number)
{
        int dec = number /10;
        int reminder = number % dec;

    if(number / 100 > 0)
    
        Console.WriteLine($"{reminder} is 3rd digit of {number}");
    
    else
    
        Console.WriteLine("3rd Digit is empty");
}

Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

ThirdDigit(n1);


/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WorkingDay(int daynumber)
{
    if (daynumber >=6)
    Console.WriteLine($"This day {daynumber} is not working day");
    else 
    Console.WriteLine($"This day {daynumber} is working day");
}

Console.WriteLine("Input number of the day on the week from 1 to 7: ");
int daynumber = Convert.ToInt32(Console.ReadLine());

WorkingDay(daynumber);

*/