
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

/*
class Program
{
    static void Main()
    {
        Console.Write("Введите M: ");
        int M = int.Parse(Console.ReadLine()!);
        
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine()!);

        if (M > 0  && M < N)
        {
            Console.WriteLine($"Натуральные числа от {M} до {N}:");
            PrintNumbers(M, N);
        }
        else
        {
            Console.WriteLine("M и N должны быть натуральными и M < N");
        }
    }

    static void PrintNumbers(int M, int N)
    {
        Console.Write(M + " ");
        if (M < N)
        {
            PrintNumbers(M + 1, N);
        }
    }
}
*/

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
class Program
{
    static void Main()
    {
        Console.Write("Введите M: ");
        int M = int.Parse(Console.ReadLine()!);
        
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine()!);
        
        if(M >= 0 && N >= 0)
        {
        int res = Ackerman(M, N);
        Console.WriteLine($"Результат функции Аккермана: {res}"); //Ура, получилось)
        }
        else
        {
            Console.WriteLine("M и N не должны быть отрицательными.");
        }
    }
    static int Ackerman(int M, int N) 
    {
        if(M == 0)
        {
            return N + 1;
        }
        else if(M > 0 && N == 0)
        {
            return Ackerman(M - 1, 1);
        }
        else
        {
            return Ackerman(M -1, Ackerman(M, N - 1));
        }
    }
}
*/
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

class Program
{
    static void Main()
    {
        int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        Console.WriteLine($"Начальный массив: [{string.Join(" ", array)}]");

        ReverseArray(array, 0, array.Length - 1);
        Console.WriteLine($"Результат: [{string.Join(" ", array)}]");
    }
    
    static void ReverseArray(int[] array, int i, int j) // Метод рекурсивного переворочивания)
    {
        if(i >= j)
        {
            return;
        }
        Swap(ref array[i], ref array[j]);
        ReverseArray(array, i + 1, j - 1);
    }
    static void Swap(ref int a, ref int b) // Метод для обмена значении. Так кажется лучше читается) 
    {
        int temp = b;
        b = a;
        a = temp;
    }
}
