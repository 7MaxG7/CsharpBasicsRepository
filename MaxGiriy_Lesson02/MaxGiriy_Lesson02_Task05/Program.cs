using System;

namespace MaxGiriy_Lesson02_Task05 {

    //    Гирий Максим
    //        5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
    //массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    class Program {

        static void Main(string[] args) {
            double minBmiNorm = 18.5, maxBmiNorm = 25;

            Console.Write("Hello, enter your mass, kg: ");
            double mass = double.Parse(Console.ReadLine());
            Console.Write("and your height, cm: ");
            double height = double.Parse(Console.ReadLine());
            double bmi = BmiCounter(mass, height);

            if (bmi < minBmiNorm) {
                Console.WriteLine($"Your BMI is {bmi:f2}, you should gain {WeightToChangeCounter(minBmiNorm - bmi, height):f1} kg");
            } else if (bmi <= maxBmiNorm) {
                Console.WriteLine($"Your form is okay, BMI: {bmi:f2}");
            } else {
                Console.WriteLine($"Your BMI is {bmi:f2}, you should lose {WeightToChangeCounter(bmi - maxBmiNorm, height):f1} kg");
            }
        }
        static double BmiCounter(double mass, double height) {
            return mass / Math.Pow(height / 100, 2);
        }
        static double WeightToChangeCounter(double bmiDelta, double height) {
            return bmiDelta * Math.Pow(height / 100, 2);
        }
    }
}
