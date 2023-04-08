// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее
// e.g. a = 2 b = 10 -> max = 10
/*
Console.WriteLine("Input the first number : ");
int num1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Input the second number : ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num1 > num2) 
{
  Console.WriteLine("The largest number is : " + num1);
}
else
{
  Console.WriteLine("The largest number is : " + num2);
}
*/


// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// e.g. 44 5 78 -> 78
/*
Console.WriteLine("Input the first number : ");
int FirstNum = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Input the second number : ");
int SecondNum = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Input the third number : ");
int ThirdNum = Convert.ToInt32 (Console.ReadLine());

if (FirstNum > SecondNum)
{
  if (FirstNum > ThirdNum)
  {
    Console.WriteLine("The largest number is : " + FirstNum);
  }
  else 
  {
    Console.WriteLine("The largest number is : " + ThirdNum);
  }
}
else
{
  Console.WriteLine("The largest number is : " + SecondNum);
}
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// e.g. 4 -> да        7 -> нет

Console.WriteLine("Input the number you want to check: ");
int numberA = Convert.ToInt32 (Console.ReadLine());

if (numberA%2 == 0)
{
  Console.WriteLine("YES, the number is even");
}
else
{
  Console.WriteLine("NO, the number is not even, it is odd");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// e.g. 8 -> 2, 4, 6, 8