using System;
using System.IO;

namespace MaxGiriy_Lesson06_Task02 {

    //Гирий Макс
    //    2. Модифицировать программу нахождения минимума функции так, чтобы можно было
    //    передавать функцию в виде делегата.
    //    а) Сделать меню с различными функциями и представить пользователю выбор, для какой
    //    функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов,
    //    в котором хранятся различные функции.
    //    б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она
    //    возвращает минимум через параметр(с использованием модификатора out).

    class Program {

        static void Main(string[] args) {
            // Инициируем массив делегатов и предлагаем пользователю выбрать вычислить одину из функций
            Functioner.Foo[] foos = new Functioner.Foo[3] { 
                delegate (double x) { return x * x - 50 * x + 10; }
                , delegate (double x) { return x * x * x - 3; }
                , delegate (double x) { return Math.Pow(2, x) / x; }
            };
            Console.WriteLine("Hello! Wehave some functions for you:");
            Console.WriteLine($"1: x^2 - 50x + 10");
            Console.WriteLine($"2: x^3 - 3");
            Console.WriteLine($"3: 2^x / x");
            int fooChoise;
            bool IsNumber;
            do {
                Console.Write("Choose the function to count: ");
                IsNumber = int.TryParse(Console.ReadLine(), out fooChoise);
            } while (!IsNumber || fooChoise < 1 || fooChoise > foos.Length);
            --fooChoise;

            double minVal, maxVal, step;
            do {
                Console.Write("Choose minium value of X: ");
                IsNumber = double.TryParse(Console.ReadLine(), out minVal);
            } while (!IsNumber);
            do {
                Console.Write("Choose maximum value of X: ");
                IsNumber = double.TryParse(Console.ReadLine(), out maxVal);
            } while (!IsNumber);
            do {
                Console.Write("Choose step: ");
                IsNumber = double.TryParse(Console.ReadLine(), out step);
            } while (!IsNumber);

            // Высчитываем значения и выводим минимальное
            Functioner.SaveFunc("data.bin", foos[fooChoise], minVal, maxVal, step);
            Console.WriteLine(Functioner.Load("data.bin").ToString("F2"));
            Console.WriteLine();
            double min = 0;
            double[] arr = Functioner.LoadWithArray("data.bin", ref min);
            Console.WriteLine($"Minimum is {min} in array: ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i].ToString("F2") + " ");
            }
            Console.ReadKey();
        }

    }
}
