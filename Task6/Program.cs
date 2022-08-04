/* 
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
int Num = new int();
Console.WriteLine("Введите число 1: ");
Num = Convert.ToInt32(Console.ReadLine());

if ((Num % 2) == 0)
{
    Console.WriteLine("even");
}
else 
{
    Console.WriteLine("odd");
}