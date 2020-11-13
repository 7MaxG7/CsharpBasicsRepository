using System;

namespace MaxGiriy_Lesson06_Task01 {

    //Гирий Макс
    //    1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
    //    типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и
    //    функцией a* sin(x).

    class Program {

        public delegate double Foo(double x, double y);

        static void Main(string[] args) {
            int a = 2;
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Foo(MyFunc), a, -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.
            Table(MyFunc, a, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(SinFoo, a, -2, 2); // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double a, double x) { return x * x; }, a, 0, 3);
        }

        public static void Table(Foo F, double a, double x, double x2) {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= x2) {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double a, double x) {
            return a * x * x;
        }
        public static double SinFoo(double a, double x) {
            return a * Math.Sin(x);
        }

    }
}
