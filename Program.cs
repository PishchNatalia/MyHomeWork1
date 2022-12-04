// Домашняя работа 1

// Задача 1.Напишите программу,которая на вход принимает два числа и выдает,какое число большее,а какое меньшее.

/*
Console.Write("Imput a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine("Первое число больше второго");
}
if (num1<num2)
{
    Console.WriteLine("Первое число меньше второго");
}

*/

// Задача 2.Напишите программу,которая принимает на вход три числа и выдает максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1>num2 & num1>num3)
{
    Console.WriteLine("Максимальное число num1");
}
if (num2>num1 & num2>num3)
{
    Console.WriteLine("Максимальное число num2");
}
else
{
 Console.WriteLine("Максимальное число num3");
}
 
*/

 // Задача3.Напишите программу,которая на вход принимает число и выдает,является ли число четным( делится ли оно на 2 без остатка).

/* 
 Console.Write("Input an integer number: ");
 int num = Convert.ToInt32(Console.ReadLine());

 if (num % 2 == 0)
 {
    Console.WriteLine("Число четное");
 }
 else

{
 Console.WriteLine("Число нечетное");
 }
 */

 // Задача 4.Напишите программу,которая на вход принимает число(N),а на выходе показывает все четные числа от 1 до N.
  /*
 Console.Write("Input an integer number: "); 
 int num = Convert.ToInt32(Console.ReadLine()); 
 
while  (current <= num) 
 {
    if (current % 2 == 0) 
    { 
        Console.Write(current + " ");
        current++;

     
    } 
 else
    {
        current++;
    }

 }
 
*