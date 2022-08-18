// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

class Program
{
    public static int Suffle (int number)
    {
        if (number < 10)
        return number;
        int digit = number % 10;
        int nextNamber = number / 10;
        return digit + Suffle(nextNamber);
    }
    public static void Main (string[]args)
    {
       Console.Write("Введите число: ");

        int N = Convert.ToInt32(Console.ReadLine());

        int result = Suffle(N);

        Console.WriteLine("Сумма цифер числа = " + result);
    }
    
}
