// Задача 25

/*Console.WriteLine("Введи число A ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число B ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {A} в степени {B} равно {Step(A,B)}");

int Step(int A, int B)
{
    int count = 1;
    int i = 1; 
    while (i <= B)
    {
    count = count * A;
    i++;
    }
    return count;
}*/

// Задача 29

/*int [] array = NewArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] NewArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}*/

// Задача 27

Console.WriteLine("Введи число N ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {N} равнa {Summa(N)}");

int Summa(int N)
{
    int count = 0;

    while (N > 0)
    {
    int a = N % 10;
    count = count + a;
    N = N / 10;
    }
    return count;
}