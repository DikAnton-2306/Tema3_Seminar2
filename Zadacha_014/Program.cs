// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine($"{number} картно 7 и 23");
}
else
{
    Console.WriteLine($"{number} не картно 7 и 23");
}