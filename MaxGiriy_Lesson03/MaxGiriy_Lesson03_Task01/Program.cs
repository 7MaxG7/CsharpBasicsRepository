using System;
using System.Runtime.InteropServices;

namespace MaxGiriy_Lesson03_Task01 {

    //Гирий Максим
    //    1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    //    Продемонстрировать работу структуры.
    //    б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить
    //    работу класса.
    //    в) Добавить диалог с использованием switch демонстрирующий работу класса.

    class Program {

        static void Main(string[] args) {
            // а)
            ComplexStruct StructA = new ComplexStruct(5, 4), StrucB = new ComplexStruct(1, 3);
            ComplexStruct delta = StructA.Minus(StrucB);
            Console.WriteLine($"Minus struct operation result: {delta.ToString()}");
            Console.WriteLine();

            // б, в)
            double aIm, aRe, bIm, bRe;
            Console.Write("Enter imaginary number of first complex number: ");
            aIm = double.Parse(Console.ReadLine());
            Console.Write("and real number of first complex number: ");
            aRe = double.Parse(Console.ReadLine());
            Console.Write("Enter imaginary number of second complex number: ");
            bIm = double.Parse(Console.ReadLine());
            Console.Write("and real number of second complex number: ");
            bRe = double.Parse(Console.ReadLine());
            ComplexClass a = new ComplexClass(aIm, aRe), b = new ComplexClass(bIm, bRe);

            char operation;
            do {
                Console.Write("Choose the operation between first and second numbers (+, -, *): ");
                operation = Console.ReadLine()[0];
            } while (operation != '+' && operation != '-' && operation != '*');

            switch (operation) {
                case '+':
                    Console.WriteLine($"Plus operation result: {a.Plus(b).ToString()}");
                    break;
                case '-':
                    Console.WriteLine($"Minus operation result: {a.Minus(b).ToString()}");
                    break;
                case '*':
                    Console.WriteLine($"Multiplication operation result: {a.Multi(b).ToString()}");
                    break;
            }
            Console.ReadKey();
        }

        struct ComplexStruct {
            public double im;
            public double re;
            public ComplexStruct(double im, double re) {
                this.im = im;
                this.re = re;
            }
            public ComplexStruct Plus(ComplexStruct x) {
                ComplexStruct y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            public ComplexStruct Multi(ComplexStruct x) {
                ComplexStruct y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public ComplexStruct Minus(ComplexStruct x) {
                return new ComplexStruct(im - x.im, re - x.re);
            }
            public override string ToString() {
                return re + "+" + im + "i";
            }
        }
        class ComplexClass {
            public double im;
            public double re;
            
            public ComplexClass() {
            }
            public ComplexClass(double im, double re) {
                this.im = im;
                this.re = re;
            }
            public ComplexClass Plus(ComplexClass x2) {
                ComplexClass x3 = new ComplexClass();
                x3.im = x2.im + this.im;
                x3.re = x2.re + this.re;
                return x3;
            }
            public ComplexClass Minus(ComplexClass x2) {
                return new ComplexClass(im - x2.im, re - x2.re);
            }
            public ComplexClass Multi(ComplexClass x2) {
                return new ComplexClass(re * x2.im + im * x2.re, re * x2.re - im * x2.im); // 9, 4 * 3, 4
            }
            public override string ToString() {
                return re + "+" + im + "i";
            }
        }
    }
}
