// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
class Program
{
    public static void Main (string[]args)
    {
        Console.Write("Введите число которое будем возводить в степень: ");

        double number = Convert.ToInt32(Console.ReadLine());

        if (number <1) Console.WriteLine (" ");

        Console.WriteLine($"Ваше число {number}");

        Console.Write ("Введите число степени:");

        double N = Convert.ToInt32(Console.ReadLine());

        if (N <1) Console.WriteLine (" ");

        for ( double i =0; i< 1; i++)
        {
            Console.WriteLine( Math.Pow (number,N));

        }

    }
}
