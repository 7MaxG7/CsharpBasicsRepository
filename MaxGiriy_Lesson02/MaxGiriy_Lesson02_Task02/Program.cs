using System;

namespace MaxGiriy_Lesson02_Task02 {

    //Гирий Максим
    //    2. Написать метод подсчета количества цифр числа

    class Program {

        static void Main(string[] args) {
            Console.WriteLine(DigitsCounter(123456789));
            Console.ReadKey();
        }
        static int DigitsCounter(int a) {
            int counter = 0;
            do {
                ++counter;
                a /= 10;
            } while (a != 0);
            return counter;
        }
    }
}
