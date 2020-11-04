using System;
using System.Collections.Generic;
using System.Linq;
using MyArrayLib;

namespace MaxGiriy_Lesson04_Task03 {

    //Гирий Максим
    //    3. а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
    //    массив определенного размера и заполняющий массив числами от начального значения с
    //    заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод
    //    Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый
    //    массив, остается без изменений), метод Multi, умножающий каждый элемент массива на
    //    определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
    //    б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу
    //    библиотеки
    //    е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)

    class Program {

        static void Main(string[] args) {
            MyArray arr = new MyArray(5, 2f, 3);
            Console.WriteLine(arr.ToString());
            Console.WriteLine(arr.Sum);
            MyArray copy = arr.Inverse();
            Console.WriteLine(copy.ToString());
            arr.Multi(2);
            Console.WriteLine(arr.ToString());
            Console.WriteLine(arr.MaxCount);
            Console.WriteLine();

            Dictionary<int, int> elemsCounter = new Dictionary<int, int>();
            for (int i = 0; i < arr.Size; ++i) {
                if (elemsCounter.ContainsKey(arr[i])) { elemsCounter[arr[i]]++;
                } else elemsCounter.Add(arr[i], 1);
            }
            foreach (var item in elemsCounter) {
                Console.WriteLine($"{item.Key, 2} - {item.Value}");
            }
        }

    }
}
