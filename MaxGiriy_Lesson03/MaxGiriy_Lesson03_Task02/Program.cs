using System;

namespace MaxGiriy_Lesson03_Task02 {

    //Гирий Максим
    //    2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    //    Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму
    //    вывести на экран, используя tryParse.

    class Program {

        static void Main(string[] args) {
            int nextNum;
            bool isNum;
            do {
                Console.Write("Enter next number or 0 to see the sum of entered positive odd numbers: ");
                isNum = int.TryParse(Console.ReadLine(), out nextNum);
                if (isNum)
                    NumbersCollector.CollectNumber(nextNum);
                else
                    continue;
            } while (nextNum != 0);
            NumbersCollector.ShowSum();
            Console.ReadKey();
        }

        static class NumbersCollector {
            static string numbers = "";
            static int sum = 0;

            public static void CollectNumber(int num) {
                if (num > 0 && num % 2 != 0) {
                    if (sum != 0) {
                        numbers += ", ";
                    }
                    numbers += num;
                    sum += num;
                }
            }
            public static void ShowSum() {
                Console.Write($"Positive odd numbers: {numbers}. The sum is {sum}");
            }
        }
    }
}
