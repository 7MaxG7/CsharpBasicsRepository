using System;

namespace MaxGiriy_Lesson02_Task01 {

    //Гирий Максим
    //    1. Написать метод, возвращающий минимальное из трёх чисел
    class Program {

        static void Main(string[] args) {
            Console.WriteLine(MinNumber(5, 3, 9));
            Console.ReadKey();
        }
        static int MinNumber(int a, int b, int c) {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }
    }
}
