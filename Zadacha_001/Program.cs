//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear();
int randomDigit = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " +randomDigit);

int ostatok = randomDigit%10; //остаток от деления на 10
Console.WriteLine("Последняя цифра случайного числа: " +ostatok);

int firstDigit = randomDigit/10;
Console.WriteLine("Первая цифра случайного числа: " +firstDigit);

int max = firstDigit;
if(ostatok > firstDigit)
    max = ostatok;

Console.WriteLine("Максимум: " +max);