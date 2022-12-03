//Задача 1: Напишите программу, 
//которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

// start
int a = 22;
int b = 3;
int c = 9;
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max > c)
{
    Console.WriteLine(max);
}
else
{
    Console.WriteLine(c);
}
// end