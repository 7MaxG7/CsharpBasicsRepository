using System;

namespace MaxGiriy_Lesson02_Task03 {

    //Гирий Максим
    //    С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello! Enter the numbers to count summ of odd entered values. Enter 0 to finish entering.");
            int a, summ = 0;
            do {
                a = int.Parse(Console.ReadLine());
                if (a % 2 != 0) summ += a;
            } while (a != 0);
            Console.WriteLine($"The summ of entered odd numbers is {summ}.");
            Console.ReadKey();
        }
    }
}
