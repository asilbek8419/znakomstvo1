// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите 1-oe число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-oe число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ee число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = c;

if (a > max)
    Console.Write(a);
    
    else if (b > max)
    Console.Write(b);
    
else
    Console.Write(c);
