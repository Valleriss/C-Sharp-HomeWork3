/* 
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите xA");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите yA");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите zA");
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите xB");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите yB");
int yB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите zB");
int zB = int.Parse(Console.ReadLine());




double result = FindRange3d(xA, yA, zA, xB, yB, zB);
Console.WriteLine(result);

double FindRange3d(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));
}