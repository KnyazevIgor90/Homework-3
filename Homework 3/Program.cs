
/*
//Задача 19

//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

void Palindrome(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
{
    Console.WriteLine($"Your number: {number} - Is palindrome ");
}
  else Console.WriteLine($"Your number: {number} - Is not palindrome ");
}

Console.Write("Input 5Digit number: ");
string number = (Console.ReadLine());
Palindrome(number);

*/

/*
//Задача 21. Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.Write("Input X 1st point: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y 1st point: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z 1st point: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X 2nd point: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y 2nd point: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z 2nd point: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance3D(xA,yA,zA,xB,yB,zB);

Console.WriteLine($"The distance between two points is {distance}");

*/


//Задача 23. Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void ShowCube(int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine($"Square number {current} = {current * current * current};");
        current++;
    }
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowCube(n);