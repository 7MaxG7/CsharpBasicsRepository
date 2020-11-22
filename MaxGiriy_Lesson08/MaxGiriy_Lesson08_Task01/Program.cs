using System;

namespace MaxGiriy_Lesson08_Task01 {

    //Гирий Макс
    //    С помощью рефлексии выведите все свойства структуры DateTime

    class Program {
        static void Main(string[] args) {

            foreach (var item in typeof(DateTime).GetProperties()) {
                Console.WriteLine($"{item.PropertyType.Name, 12} {item.Name}");
            }

        }
    }
}
