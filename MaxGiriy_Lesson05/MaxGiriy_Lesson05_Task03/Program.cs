using System;

namespace MaxGiriy_Lesson05_Task03 {

    //Гирий Максим
    //    3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой
    //    другой.
    //    Например:
    //    badc являются перестановкой abcd.

    class Program {
        static void Main(string[] args) {
            string str1 = "azz";
            string str2 = "zzaa";
            if (StringsComparer.CompareStrings(str1, str2)) {
                Console.WriteLine("Strings contain equal symbols");
            } else {
                Console.WriteLine("Strings contain different symbols");
            }
        }
    }
}
