//Задача 3: Напишите программу,которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

// start
//Console.Write("Введите натуральное число: ");
//int N = Convert.ToInt32(Console.ReadLine());


int N = 5;
for (int i = 1; i <= N; i++)
{
if (i % 2 == 0)
{
    Console.Write(i + " ");
}
}
 Console.ReadKey();


