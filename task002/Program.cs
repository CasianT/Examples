// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число, a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, c");
int c = int.Parse(Console.ReadLine());
 
if ( a > b && a > c )
{
    Console.WriteLine($" a = {a}, b = {b}, c = {c} -> max = {a} ");
}
else if ( b > c)
 {
    Console.WriteLine($" a = {a}, b = {b}, c = {c} -> max = {b} ");
 }
 else
 {
    Console.WriteLine($" a = {a}, b = {b}, c = {c} -> max = {c} ");
 }
 