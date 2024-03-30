// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Recurs(int m, int n)
{
    if (ProverkaNat(m, n) == false)
    {
        if (n > 0)
        {
            if (n == m)
            {
                System.Console.Write(n + " ");
                return;
            }
            Recurs(m, n - 1);
            System.Console.Write(n + " ");
        }
    }

}

bool ProverkaNat(int m, int n)
{
    if (n < 1 & m < 1)
    {
        System.Console.WriteLine("числа не натуральные");
        return true;
    }
    return false;
}

System.Console.WriteLine("input M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

Recurs(M, N);



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return Ackermann(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return 0;
}

bool Check(int m, int n)
{
    if (m < 0 && n < 0)
    {
        Console.WriteLine("Введённые числа отрицательные.");
        return true;
    }
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Одно из чисел отрицательное.");
        return true;
    }
    return false;
}

System.Console.WriteLine();
Console.WriteLine("Введите числа m и n для функции Аккермана:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

if (Check(m, n) == false)
{
    int result = Ackermann(m, n);
    Console.WriteLine($"Значение Функции Аккермана от ({m}, {n}) = {result}");
}


// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] CreateArray(int n, int min, int max)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length /*n*/; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

void RecursArr(int[] arr, int i)
    {
        if (i < arr.Length)
        {
            RecursArr(arr, i + 1);
            Console.Write(arr[i]+ " ");
        }
    }


System.Console.WriteLine("input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);
System.Console.WriteLine("Перевёрнутый массив: ");
RecursArr(array, 0);
