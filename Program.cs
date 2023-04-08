/* 
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

CubeTable(N);

void CubeTable(int N)
{
    Console.Write(1);
    for (int i = 2; i <= N; i++)
    {
        double cube = Math.Pow(i, 3);
        Console.Write($", {cube}");
    }
}