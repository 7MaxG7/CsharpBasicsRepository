using System;
using System.Collections;
using System.IO;

namespace MaxGiriy_Lesson06_Task03 {

    //Гирий Макс
    //    3. Переделать программу Пример использования коллекций для решения следующих задач:
    //    а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный
    //    массив);
    //    в) отсортировать список по возрасту студента;
    //    г) * отсортировать список по курсу и возрасту студента;

    class Program {
        static void Main(string[] args) {
            ListCreator list = new ListCreator("students.csv", 100);
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StudentsInitializer.Initialize("students.csv");
            Console.WriteLine("Всего студентов: {0}", StudentsInitializer.StudetsNumber);
            Console.WriteLine($"Студентов на 5 и 6 курсах: {StudentsInitializer.GetNumberStudentsOfCourse(5) + StudentsInitializer.GetNumberStudentsOfCourse(6)}");
            int minAge = 18, maxAge = 20;
            int[] coursesTable = StudentsInitializer.SorterByCourse(StudentsInitializer.GetStudentsOgAge(minAge, maxAge));
            Console.Write($"Студентов от {minAge} до {maxAge} лет по курсам: ");
            for (int i = 0; i < coursesTable.Length; i++) {
                Console.Write($"{i + 1} - {coursesTable[i]}, ");
            }
            Console.WriteLine();
            // Вычислим время обработки данных
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }

    }
}
