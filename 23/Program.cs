/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int[] A = new int[num];
for (int i = 1; i < num; i++) 
{
    A[i-1] = i*i*i;
    Console.WriteLine(A[i-1]);
}

