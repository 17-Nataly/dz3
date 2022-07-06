/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double number(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = 0;
    if(x1 == x2 && y1 == y2 && z1 ==z2)
    {
        return result;
    }
    result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
    return result;
}

double A = number(7,-5, 0, 1, -1, 9);
Console.WriteLine(A);