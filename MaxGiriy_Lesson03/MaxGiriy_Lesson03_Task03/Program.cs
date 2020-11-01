using System;
using System.Diagnostics;

namespace MaxGiriy_Lesson03_Task03 {

    //Гирий Максим
    //    3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    //     Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
    //     программу, демонстрирующую все разработанные элементы класса.
    //     * Добавить свойства типа int для доступа к числителю и знаменателю;
    //    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    //    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    //    ArgumentException("Знаменатель не может быть равен 0");
    //    *** Добавить упрощение дробей.

    class Program {

        static void Main(string[] args) {
            Rational a, b;
            do {
                Console.Write("Enter first rational number numerator: ");
                int aNum = int.Parse(Console.ReadLine());
                Console.Write("Enter first rational number denomenator: ");
                int aDen = int.Parse(Console.ReadLine());
                a = new Rational(aNum, aDen);
                Console.WriteLine();
            } while (double.IsNaN(a.Decimal));
            do {
                Console.Write("Enter second rational number numerator: ");
                int bNum = int.Parse(Console.ReadLine());
                Console.Write("Enter second rational number denomenator: ");
                int bDen = int.Parse(Console.ReadLine());
                b = new Rational(bNum, bDen);
                Console.WriteLine();
            } while (double.IsNaN(b.Decimal));

            while (true) {
                if (MakeOperation(a, b)) {
                    break;
                }
            }
            Console.ReadKey();
        }
        static bool MakeOperation(Rational a, Rational b) {
            Console.Write("Choose the operation between first and second numbers (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            switch (operation) {
                case '+':
                    Console.WriteLine($"Plus operation result: {a.Add(b)}");
                    break;
                case '-':
                    Console.WriteLine($"Minus operation result: {a.Subtract(b)}");
                    break;
                case '*':
                    Console.WriteLine($"Multiplication operation result: {a.Multiply(b)}");
                    break;
                case '/':
                    Console.WriteLine($"Multiplication operation result: {a.Devide(b)}");
                    break;
                default:
                    Console.WriteLine("Wrong operation\n");
                    return false;
            }
            return true;
        }

        class Rational {
            int denomenator;
            public int Numerator { get; set; }

            public int Denominator {
                get { return denomenator; }
                set {
                    try {
                        if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                        denomenator = value;
                    }
                    catch (ArgumentException ae) { Console.WriteLine(ae.Message); }
                }
            }
            public double Decimal {
                get { return (double)Numerator / Denominator; }
            }

            public Rational(int numerator, int denominator) {
                try {
                    if (denominator == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                    Numerator = numerator;
                    Denominator = denominator;
                } catch (ArgumentException ae) { Console.WriteLine(ae.Message); }
            }

            /// <summary>
            /// Сложение с другой дробью
            /// </summary>
            public Rational Add(Rational other) {
                Rational tmp = new Rational(Numerator * other.Denominator + Denominator * other.Numerator, Denominator * other.Denominator);
                return tmp.ReduceFraction();
            }
            /// <summary>
            /// Вычитание другой дроби
            /// </summary>
            public Rational Subtract(Rational other) {
                Rational tmp = new Rational(Numerator * other.Denominator - Denominator * other.Numerator, Denominator * other.Denominator);
                return tmp.ReduceFraction();
            }
            /// <summary>
            /// Перемножение с другой дробью
            /// </summary>
            public Rational Multiply(Rational other) {
                Rational tmp = new Rational(Numerator * other.Numerator, Denominator * other.Denominator);
                return tmp.ReduceFraction();
            }
            /// <summary>
            /// Деление на другую дробь
            /// </summary>
            public Rational Devide(Rational other) {
                return Multiply(new Rational(other.Denominator, other.Numerator));
            }
            /// <summary>
            /// Упрощение дроби
            /// </summary>
            public Rational ReduceFraction() {
                int gfc = FindGcf(Numerator, Denominator);
                return new Rational(Numerator /= gfc, Denominator /= gfc);
            }
            /// <summary>
            /// Поиск НОД
            /// </summary>
            static int FindGcf(int a, int b) {
                while (a != b) {
                    if (a > b) { a = a - b;
                    } else { b = b - a; }
                }
                return a;
            }
            public override string ToString() {
                return $"{Numerator}/{denomenator}";
            }
        }
    }
}
