/*
//Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

void ShowNumber(int n,int m)
{
    if (m!=n)
    {
        if (n>m) 
        {
            ShowNumber(n-1,m);
            Console.WriteLine(n+" ");
        }
        else
        {
            ShowNumber(m-1,n);
            Console.WriteLine(m+" ");
        }
    }
    else
        Console.WriteLine(m+" ");
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
ShowNumber(a,b);
*/

/*
//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int n,int m)
{
    if (m!=n)
    {
        if (m>n)
            return n+SumNumbers(n+1,m);
        else 
            return m+SumNumbers(n,m+1);
    }
    else
        return m;
    
}
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int sum=SumNumbers(a,b);
Console.WriteLine($"The summ of all numbers is {sum}.");
*/


/*
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


int Akkerman(int n,int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());


int function=Akkerman(a,b);
Console.WriteLine($"Function Akkerman is {function}.");

*/