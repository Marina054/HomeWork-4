// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

class Program
{
    static int[] CreaterArray (int number)
    {
        int[]array =new int [number];
        for (int i=0; i< array.Length; i++)
        {
            array[i] = i +1;
        } 
        return array;

    }

    static void WriteArray(int[]array)
    {
        Console.WriteLine("Вывод массива");
        for (int i=0; i< array.Length; i++)
        {
            Console.Write(array [i] + " ");
        }
    }
    static void Main (string[]args)
    {
        Console.Write("Введите колличество чисел в массиве: ");

        int N = Convert.ToInt32(Console.ReadLine());
        int[]array = CreaterArray(N);
        WriteArray (array);
        Console.ReadLine();
    }
}