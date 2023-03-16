using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int reversedNumber = 0;
        while (temp != 0) {
            reversedNumber = reversedNumber * 10 + temp % 10;
            temp /= 10;
        }

        if (number == reversedNumber) {
            Console.WriteLine("Число {0} является палиндромом", number);
        } else {
            Console.WriteLine("Число {0} не является палиндромом", number);
        }
    }
}
