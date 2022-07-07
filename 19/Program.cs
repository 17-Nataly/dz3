/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*bool isPalindromLiht(int[] arr) {
    bool result = false;
    const N = arr.Lenght;
    for (int i = 0; i < N / 2; i++) {
        if (arr[i] !== arr[N-i-1])  {
            Console.WriteLine("Не палиндром");
            return result;
        }
    }
    result = true;
    Console.WriteLine("Число - палиндром");
    
    return result;
}

isPalindromLiht(12345);*/

/*bool isPalindrom(int x) {
    int div = 1;
    while (x / div >= 10) {
        div *= 10;
    }
    Console.WriteLine(div);
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

isPalindrom(12345);*/


class Program {  
    static void Main(string[] args) {  
        int num, rem, sum = 0, temp;      
        Console.WriteLine("Определение является ли число палиндромом");  
        Console.Write("Введите число: ");  
        num = Convert.ToInt32(Console.ReadLine());  
        temp = num;  
        while (num > 0) {  
            rem = num % 10;     
            num = num / 10;    
            sum = sum * 10 + rem;   
        }  
        Console.WriteLine("Перевернутое число: {0} ", sum);  
        if (temp == sum) 
        {  
            Console.WriteLine("Это число палиндром");  
        } else {  
            Console.WriteLine("Это число не палиндром");  
        }  
        Console.ReadLine();  
    }  
}    
  