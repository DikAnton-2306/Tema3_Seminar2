//Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear(); //Clear() очищает терминал
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if ((numberA == numberB * numberB) || (numberB == numberA * numberA))
{
    Console.WriteLine("Да, одно число является квадратом другого");
}
else
{
    Console.WriteLine("НЕТ, одно число НЕ является квадратом другого");
}