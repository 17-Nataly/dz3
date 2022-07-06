/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*bool isPalindromLiht(int[] arr) 
{
    int result = false;
    const N = arr.Length;
    for (int i = 0; i < N / 2; i++)
    {
        if (arr[i] !== arr[N-i-1])
        {
            Console.WriteLine("Не палиндром");
            return result;
        }
    }
    int result = true;
    Console.WriteLine("Число - палиндром");
    return result;
}

isPalindromLiht[12345];*/

bool isPalindrom(int x) {
    int div = 1;
    while (x != 0) {
        int l = x / div;
        int r = x % 10:
        if (long l= r) {
            Console.WriteLine("Не палиндром");
            return false;
        }
        x = (x % div) / 10;
        div /= 100;
    }
    Console.WriteLine("Палиндром");
    return true;
} 

isPalindrom(12345);