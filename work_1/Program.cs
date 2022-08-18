// class Program
// {
//     public static void Main (string[]args)
//     {
//         Console.Write("Введите число которое будем возводить в степень: ");

//         int number = Convert.ToInt32(Console.ReadLine());

//         if (number <1) Console.WriteLine (" ");

//         Console.WriteLine($"Ваше число {number}");

//         Console.Write ("Введите число степени:");

//         int N = Convert.ToInt32(Console.ReadLine());

//         if (N <1) Console.WriteLine (" ");

//         for ( int i =1; i< number; i++)
//         {
//             Console.WriteLine (MathF.Pow (i+1, N) +";");
//         }

//     }
// }


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


// {(long)Math.Pow(value, power):N0}