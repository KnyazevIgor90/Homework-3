/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine($"{n1} is biggest number,  {n2} is lower number");
}
else
{
    Console.WriteLine($"{n2} is biggest number,  {n1} is lower number");
}
*/
/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
if (n1 > n3)
{
    Console.WriteLine($"{n1} is biggest number");
}
if (n2 > n1)
if (n2 > n3)
{
    Console.WriteLine($"{n2} is biggest number");
}
else
{
    Console.WriteLine($"{n3} is biggest number");
}
*/
/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 % 2 == 0)
{
    Console.WriteLine($"{n1} is even number");
}
else
{
    Console.WriteLine($"{n1} is not even number");
}
*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;
Console.WriteLine($"All even numbers from 1 to {number}");
while(current <= number)
{
    Console.Write(current + " ");
    current = current+2;
}
*/