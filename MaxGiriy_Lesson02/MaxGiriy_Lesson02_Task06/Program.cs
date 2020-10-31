using System;

namespace MaxGiriy_Lesson02_Task06 {

    //Гирий Максим
    //    * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
    //    000. «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать
    //    подсчёт времени выполнения программы, используя структуру DateTime.

    class Program {

        static void Main(string[] args) {
            int numToCheck = 1, endNum = 1_000_000_000;
            int counter = 0;
            DateTime startTime = DateTime.Now;
            while (numToCheck <= endNum) {
                if (IsGoodNumber(numToCheck)) ++counter;
                ++numToCheck;
            }
            Console.Write($"There are {counter} good numbers in range. Counted for {DateTime.Now - startTime}");
            Console.ReadKey();
        }
        static bool IsGoodNumber(int a) {
            int sum = 0, b = a;
            do {
                sum += b % 10;
                b /= 10;
            } while (b != 0);
            return a % sum == 0;
        }
    }
}
