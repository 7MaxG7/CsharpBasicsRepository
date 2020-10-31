using System;

namespace MaxGiriy_Lesson02_Task07 {

    //Гирий Максим
    //    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    //    б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

    class Program {

        static void Main(string[] args) {
            int a, b;
            Console.Write("Hello! Enter start number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("and finish number: ");
            b = int.Parse(Console.ReadLine());

            RecursiveIntOutput(a, b);
            Console.WriteLine();
            Console.WriteLine($"The summ is {RecursiveAdding(a, b)}");
            Console.ReadKey();
        }
        static void RecursiveIntOutput(int start, int finish) {
            Console.WriteLine(start);
            if (start < finish) RecursiveIntOutput(++start, finish);
        }
        static int RecursiveAdding(int start, int finish) {
            if (start == finish) return finish;
            else return start + RecursiveAdding(++start, finish);
        }
    }
}
